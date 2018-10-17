using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WeBGame.Models;
using WeBGame.Service;

namespace WeBGame.Controllers
{
    /// <summary>
    /// 验证控制器
    /// 管理登录和注册
    /// </summary>
    public class AuthenticationController : Controller
    {
        private readonly IUserService _service;

        public AuthenticationController(IUserService service)
        {
            this._service = service;
        }

        // GET
        public IActionResult Index()
        {
            return View("Registration");
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View("Login");
        }

        [HttpPost]
        public IActionResult Login(LoginFormModel form, string returnUrl)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.isValid = false;
                return View("Login");
            }

            User user = _service.GetUser(form.Account, form.Password);
            if (user == null)
            {
                ModelState.AddModelError("LoginFailed", "用户名或密码错误");
                ViewBag.isValid = false;
                return View("Login");
            }


            var identity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme);
            identity.AddClaim(new Claim(ClaimTypes.Sid, user.UserName));
            identity.AddClaim(new Claim(ClaimTypes.Name, user.UserName));
            HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                new ClaimsPrincipal(identity));
            HttpContext.Session.SetString("CurrentUser", user.UserName);

            if (returnUrl != null)
                return Redirect(returnUrl);
            return RedirectToAction(nameof(HomeController.Index), "Home");
        }

        [HttpGet]
        public IActionResult Registration()
        {
            return View("Registration");
        }

        [HttpPost]
        public IActionResult Registration(User user)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.isValid = false;
                return View("Registration");
            }
            _service.AddUser(user);
            LoginFormModel form = new LoginFormModel();
            form.Account = user.UserName;
            form.Password = user.Password;
            return Login(form, null);
        }

        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return Redirect("Login");
        }
    }
}