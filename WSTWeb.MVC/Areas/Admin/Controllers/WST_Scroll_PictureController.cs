using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WSTWeb.MVC.Areas.Admin.Controllers
{
    public class WST_Scroll_PictureController : Controller
    {
        //轮播图
        [Area("Admin")]
        public IActionResult Index()
        {
            return View();
        }

    }
}
