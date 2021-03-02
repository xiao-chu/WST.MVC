using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Http;
using System.IO;


namespace WSTWeb.MVC.Areas.Admin.Controllers
{
    public class ArticleController : Controller
    {
        [Area("Admin")]
        public ActionResult Index()
        {
            return View();
        }

        [Area("Admin")]
        [HttpPost]
        public IActionResult Upload(IFormFile formFile=null)
        {
            if (formFile.Length > 0 && formFile != null)
            {
                FileInfo fi = new FileInfo(formFile.FileName);
                //新名字
                string fileName = Guid.NewGuid() + fi.Extension;
                //存储路径
                string filePath=Path.Combine(Directory.GetDirectoryRoot("/images/"), fileName);
                //数据库存储的位置
                string src = "/images/" + fileName;
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                     formFile.CopyToAsync(stream);
                }
                return Json(new { data = src, code = 1, msg = "上传成功!" });
            }
            else
            {
                return Json(new { data = "", code = 1, msg = "失败!" });

            }
        }
    }
}
