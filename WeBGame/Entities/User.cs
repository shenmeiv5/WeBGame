using System;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace WeBGame.Models
{
    public class User : Entity
    {
        /// <summary>
        /// 用户名
        /// </summary>
        [Required(ErrorMessage = "用户名不能为空")]
        [MaxLength(20, ErrorMessage = "用户名不能超过20个字符")]
        public string UserName { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        [Required(ErrorMessage = "密码不能为空")]
        [RegularExpression("^(?![0-9]+$)(?![a-zA-Z]+$)[0-9A-Za-z\\S]{8,20}$", ErrorMessage = "密码不能小于8位")]
        public string Password { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        [Required(ErrorMessage = "邮箱不能为空")]
        [RegularExpression("\\w[-\\w+]*@([A-Za-z0-9][-A-Za-z0-9]+\\.)+[A-Za-z]{2,14}", ErrorMessage = "邮箱不合法")]
        public string Email { get; set; }

        /// <summary>
        /// 账号创建时间
        /// </summary>
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// 最近登录时间
        /// </summary>
        public DateTime LastLoginDateTime { get; set; }

        /// <summary>
        /// 登录次数
        /// </summary>
        public int LoginTime { get;set; }

        /// <summary>
        /// 用户余额
        /// </summary>
        public float Balance { get; set; }
    }
}