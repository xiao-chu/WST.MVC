using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common;
namespace WSTWeb.MVC.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        [Area("Admin")]
        [MyAuthorization]
        public IActionResult Index()
        {
            return View();
        }
    }
}
