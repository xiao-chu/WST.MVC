using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WSTWeb.MVC.Controllers
{
    public class AboutUsrecruitController : Controller
    {
        //关于我们
        public IActionResult Index()
        {
            return View();
        }
    }
}
