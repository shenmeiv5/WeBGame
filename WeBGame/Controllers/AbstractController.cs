using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace WeBGame.Controllers
{
    /// <summary>
    /// 控制器基类，对需要登录权限的控制器进行验证
    /// </summary>
    public class AbstractController : Controller
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            byte[] result;
            context.HttpContext.Session.TryGetValue("CurrentUser", out result);
            if(result == null)
                return;
            base.OnActionExecuting(context);
        }
    }
}