using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using System.IO;


namespace WSTWeb.MVC.Areas.Admin.Controllers
{
    public class ArticleController : Controller
    {
        //依赖注入  IHostingEnvironment主机环境
        private readonly IHostingEnvironment hostingEnvironment;
        public ArticleController(IHostingEnvironment _hostingEnvironment)
        {
            hostingEnvironment = _hostingEnvironment;
        }

        [Area("Admin")]
        public ActionResult Index()
        {
            return View();
        }

        [Area("Admin")]
        //图片上传
        [HttpPost]
        public ObjectResult UploadImg(IFormFile formfile)
        {
            //获取文件
            var files = Request.Form.Files;

            //文件是否上传
            if (files.Count == 0)
            {
                return Ok($"图片未上传，请上传文件");
            }
            //获取文件名
            var filePath = formfile.FileName;

            string fileExt = Path.GetExtension(filePath);//获取后缀名
            //随机生成新的文件名
            var newFileName = Guid.NewGuid().ToString() + fileExt;

            //获取主机根路径+Upload路径
            var path = Path.Combine(hostingEnvironment.ContentRootPath, "images");

            if (!Directory.Exists(path))//查询目录是否存在
            {
                Directory.CreateDirectory(path.ToString());//创建目录
            }

            //完整的文件路径
            var completeFilePath = Path.Combine(path, newFileName);
            //保存文件
            using (var stream = new FileStream(completeFilePath, FileMode.Create))
            {
                formfile.CopyToAsync(stream);
                stream.Flush();
            }
            //成功
            return Ok(new { code=1,result= newFileName ,msg="上传成功"});

        }


       
    }
}
