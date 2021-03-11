using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WSTWeb.MVC.Controllers
{
    public class BlackListController : Controller
    {
        //黑名单
        public IActionResult Index()
        {
            return View();
        }
    }
}
