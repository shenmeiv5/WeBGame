using System.ComponentModel.DataAnnotations;

namespace WeBGame.Models
{
    /// <summary>
    /// 前端提交的登录表单模型
    /// </summary>
    public class LoginFormModel
    {
        /// <summary>
        /// 用户名或邮箱
        /// </summary>
        [Required(ErrorMessage = "请输入用户名或邮箱")]
        public string Account { get; set; }
        [Required(ErrorMessage = "请输入密码")]
        public string Password { get; set; }
    }
}