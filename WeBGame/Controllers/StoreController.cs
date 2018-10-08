using Microsoft.AspNetCore.Mvc;

namespace WeBGame.Controllers
{
    public class StoreController : Controller
    {
        public IActionResult Index()
        {
            return View("Store");
        }
    }
}