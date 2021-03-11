using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace WSTWeb.MVC.Areas.Admin.Controllers
{
    public class BlackListController : Controller
    {
        private IHostingEnvironment _hostingEnvironment;



        public BlackListController(IHostingEnvironment hostingEnvironment)

        {
            _hostingEnvironment = hostingEnvironment;

        }

        public IActionResult Export()

        {

            string sWebRootFolder = _hostingEnvironment.WebRootPath;

            string sFileName = "黑名单.xlsx";



            FileInfo file = new FileInfo(Path.Combine(sWebRootFolder, sFileName));

            file.Delete();

            using (ExcelPackage package = new ExcelPackage(file))

            {
                // 添加worksheet

                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("黑名单");

                //添加头
                worksheet.Cells[1, 1].Value = "序号";
                worksheet.Cells[1, 2].Value = "违纪类别";
                worksheet.Cells[1, 3].Value = "违纪单位/人";
                worksheet.Cells[1, 4].Value = "证件号";
                worksheet.Cells[1, 5].Value = "违纪事项";
                worksheet.Cells[1, 6].Value = "状态";
                worksheet.Cells[1, 7].Value = "更新时间";
                worksheet.Cells[1, 8].Value = "发布人";
                //添加值

                worksheet.Cells["A2"].Value = 1000;

                worksheet.Cells["B2"].Value = "For丨丶";

                worksheet.Cells["C2"].Value = "网页链接";


                worksheet.Cells["A3"].Value = 1001;

                worksheet.Cells["B3"].Value = "For丨丶Tomorrow";

                worksheet.Cells["C3"].Value = "网页链接";



                worksheet.Cells["C3"].Style.Font.Bold = true;

                package.Save();

            }

            return File(sFileName, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", sFileName);

        }

        //显示
        [Area("Admin")]
        public IActionResult Index()
        {
            return View();
        }

        //查看
        [Area("Admin")]
        public IActionResult lookBlack(int Bid)
        {
            return View();
        }
    }
}
