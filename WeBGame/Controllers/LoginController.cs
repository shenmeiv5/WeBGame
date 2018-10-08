using Microsoft.AspNetCore.Mvc;

namespace WeBGame.Controllers
{
    public class LoginController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}