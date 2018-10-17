using System;

namespace WeBGame.Models
{
    public class Game : Entity
    {
        /// <summary>
        /// 游戏名
        /// </summary>
        public string GameName { get; set; }

        /// <summary>
        /// 游戏描述
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 游戏类型
        /// </summary>
        public string GameType { get; set; }

        /// <summary>
        /// 游戏开发商
        /// </summary>
        public string GameDeveloper { get; set; }

        /// <summary>
        /// 游戏发行商
        /// </summary>
        public string GamePublisher { get; set; }

        /// <summary>
        /// 发售日期
        /// </summary>
        public DateTime SaleDate { get; set; }

        /// <summary>
        /// 支持语言
        /// </summary>
        public string SupportLanguage { get; set; }

        /// <summary>
        /// 游戏评价（好评率
        /// </summary>
        public double GameEvaluate { get; set; }
    }
}
