using Microsoft.AspNetCore.Mvc;

namespace WeBGame.Controllers
{
    public class AuthenticationController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DoLogin()
        {
            return new EmptyResult();
        }
    }
}