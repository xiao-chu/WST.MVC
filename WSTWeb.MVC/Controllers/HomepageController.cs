using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WSTWeb.MVC.Controllers
{
    public class HomepageController : Controller
    {
        //首页
        public IActionResult Index()
        {
            return View();
        }
        //关于我们
        public IActionResult AboutUS()
        {
            return View();
        }
        //行为准则
        public IActionResult AboutBehavior()
        {
            return View();
        }
        //行业/服务
        public IActionResult Service2()
        {
            return View();
        }
    }
}
