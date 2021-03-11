using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace WSTWeb.MVC.Controllers
{
    public class ComplainController : Controller
    {
        //举报投诉
        public IActionResult Index()
        {
            return View();
        }
    }
}
