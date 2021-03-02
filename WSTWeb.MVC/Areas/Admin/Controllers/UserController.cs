using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WSTWeb.MVC.Areas.Admin.Controllers
{
    public class UserController : Controller
    {
        [Area("Admin")]
        //登录
        public IActionResult Login()
        {
            return View();
        }
        //编辑个人信息
        [Area("Admin")]
        public IActionResult Edit()
        {
            return View();
        }
        //用户注册信息显示
        [Area("Admin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
