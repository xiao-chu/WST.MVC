using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
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

        //上传图片
        [Area("Admin")]
        [HttpPost]
        public object Upload([FromForm] IFormCollection formData)
        {
            IFormFile uploadfile = formData.Files[0];
            //判断是否上传了文件
            if (uploadfile != null)
            {
                //文件后缀
                var fileExtension = Path.GetExtension(uploadfile.FileName);
                var strDateTime = DateTime.Now.ToString("yyMMddhhmmssfff"); //取得时间字符串
                var strRan = Convert.ToString(new Random().Next(100, 999)); //生成三位随机数
                //新名字
                var saveName = strDateTime + strRan + fileExtension;
                //数据库存储路径
                var di = ("/images/" + saveName);
                //获取文件存储的路径
                var bi = Path.Combine("wwwroot", "images");
                //判断是否存在该文件夹
                if (!Directory.Exists(bi))
                {
                    Directory.CreateDirectory(bi);
                }
                //文件写入
                using (FileStream fs = System.IO.File.Create(Path.Combine(bi, saveName)))
                {
                    uploadfile.CopyTo(fs);
                    fs.Flush();
                }
                //返回路径，返回的状态码
                return new { code = 0, path = di };
            }
            //失败的状态码
            return new { code = 1 };
        }

    }
}
