﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WSTWeb.MVC.Models
{
    public class BlackListViewModel
    {
        public int Bid { get; set; }               //序号
        public string Btype { get; set; }          //违纪类别
        public string Bunit { get; set; }          //违纪单位/人
        public string Bnumber { get; set; }        //证件号
        public string Bmatter { get; set; }        //违纪事项
        public int Bstate { get; set; }         //状态
        public DateTime Btime { get; set; }        //更新时间
        public string Bpeople { get; set; }         //发布人
    }
}
