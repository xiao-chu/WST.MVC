using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WSTWeb.MVC.Models
{
    public class RecruitViewModel
    {
        public int Rid { get; set; }   //序号

        public string Rkind { get; set; } //种类

        public string Rposition { get; set; } //职位

        public string Rdescribe { get; set; }  //描述

        public int Rsheng { get; set; } //省外键
        public string sheng { get; set; } //省名称

        public int Rshi { get; set; }   //市外键
        public string shi { get; set; } //市名称

        public int Rqu { get; set; }    //区外键
        public string qu { get; set; } //区名称

        public string Raddress { get; set; } //详细地址

        public string Rcompany { get; set; } //公司

        public int Rstate { get; set; }    //状态

        public DateTime Rtime { get; set; } //发布时间

        public string Rpeople { get; set; } //发布人
    }
}
