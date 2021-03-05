using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WSTWeb.MVC.Controllers
{
    public class BlackListController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
