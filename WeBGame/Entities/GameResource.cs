namespace WeBGame.Models
{
    /// <summary>
    /// 游戏资源实体
    /// </summary>
    public class GameResource:Entity
    {
        public int GameID { get; set; }
        public string ImageAddr { get; set; }
    }
}