using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace WSTWeb.MVC.Areas.Admin.Controllers
{
    public class RecruitController : Controller
    {
        //显示
        [Area("Admin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
