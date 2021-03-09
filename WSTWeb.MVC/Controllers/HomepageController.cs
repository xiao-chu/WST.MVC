using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WSTWeb.MVC.Controllers
{
    public class HomepageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        //文章页面
        public ActionResult ArticlePage()
        {
            return View();
        }
        //要闻资讯
        public ActionResult ImpNews()
        {
            return View();
        }
        //成功的人
        public ActionResult Succeed()
        {
            return View();
        }
        //规矩
        public ActionResult Rule()
        {
            return View();
        }
        //廉洁
        public ActionResult Honest()
        {
            return View();
        }
        //稳定
        public ActionResult Steady()
        {
            return View();
        }
    }
}
