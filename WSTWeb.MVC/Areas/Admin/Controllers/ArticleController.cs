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

        //上传文件
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
                return new { code = 1, result = di, msg = "上传成功" };
            }
            //失败的状态码
            return new { code = -1 , msg = "未获取文件" };
        }
        //[Area("Admin")]
        //图片上传
        //[HttpPost]
        //public object UploadImg([FromForm] IFormCollection fc)
        //{
        //    //获取文件
        //    IFormFile formFile = fc.Files[0];
            
        //    //文件是否上传
        //    if (formFile.Length == 0)
        //    {
        //        return new { code=-1,mag="未获取文件"};
        //    }
        //    //获取文件名
        //    var filePath = formFile.FileName;

        //    string fileExt = Path.GetExtension(filePath);//获取后缀名
        //    //随机生成新的文件名
        //    var newFileName = Guid.NewGuid().ToString().Substring(0,12)+ fileExt;

        //    //获取文件路径
        //    var path = Path.Combine("wwwroot", "images");

        //    if (!Directory.Exists(path))//查询目录是否存在
        //    {
        //        Directory.CreateDirectory(path.ToString());//创建目录
        //    }

        //    //完整的文件路径
        //    var completeFilePath = Path.Combine(path, newFileName);
        //    //保存文件
        //    using (FileStream fs= System.IO.File.Create(completeFilePath))
        //    {
        //        formFile.CopyToAsync(fs);
        //        fs.Flush();
        //    }
        //    //成功
        //    return new { code=1,result= "/images/"+newFileName ,msg="上传成功"};

        //}

    }
}
