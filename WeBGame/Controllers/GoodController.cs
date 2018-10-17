using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WeBGame.Controllers
{
    public class GoodController : Controller
    {
        public IActionResult Index()
        {
            return View("Good");
        }
    }
}