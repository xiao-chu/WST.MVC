using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace WSTWeb.MVC.Controllers
{
    public class AutonymController : Controller
    {
        //实名举报
        public IActionResult Index()
        {
            return View();
        }

        //文件上传
        public object InsertWord([FromForm] IFormCollection formData)
        {
            IFormFile upLoadfile = formData.Files[0];
            if (upLoadfile != null)
            {
                //文件后缀
                var fileExtension = Path.GetExtension(upLoadfile.FileName);
                var strDateTime = DateTime.Now.ToString("yyMMdd");
                var strRan = Convert.ToString(new Random().Next(100, 999));
                var saveName = strDateTime + strRan + fileExtension;
                var path = "word"; 
                var di = ("/" + path + "/" + saveName);
                var bi = Path.Combine("wwwroot", path);
                if (!Directory.Exists(bi))
                {
                    Directory.CreateDirectory(bi);
                }
                using (FileStream fs = System.IO.File.Create(Path.Combine(bi, saveName)))
                {
                    upLoadfile.CopyTo(fs);
                    fs.Flush();
                }
                return new { code = 0, path = di };
            }
            return new { code = 1 };
        }
    }
}
