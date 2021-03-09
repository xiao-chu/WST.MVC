using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Common
{
    public class MyAuthorization : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            //获取cookie中存储的id
            string id = context.HttpContext.Request.Cookies["userId"]?.ToString();
            //判断id是否存在
            if (string.IsNullOrEmpty(id))
            {
                //返回登陆页面
                context.Result = new RedirectResult("/Admin/User/Login");
            };
            base.OnActionExecuting(context);
        }
    }
}
