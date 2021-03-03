using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WSTWeb.MVC.Areas.Admin.Controllers
{
    public class QuestionnaireController : Controller
    {
        [Area("Admin")]
        public IActionResult QuestionnaireShow()
        {
            return View();
        }
    }
}
