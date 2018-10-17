using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WeBGame.Components
{
    /// <summary>
    /// 布局视图部件
    /// 切换登录注册部件和问候注销部件
    /// </summary>
    public class LayoutViewComponent:ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            string currentUser = HttpContext.Session.GetString("CurrentUser");
            ViewBag.Username = currentUser;
            return currentUser == null ? View("Login") : View("Greeting");
        }
    }
}