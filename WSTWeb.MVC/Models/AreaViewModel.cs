using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WSTWeb.MVC.Models
{
    public class AreaViewModel
    {
        public int Aid { get; set; }  //主键
        public string Aname { get; set; }  //地址名称
        public int Apid { get; set; }       //父级id
    }
}
