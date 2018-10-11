using System.Collections.Generic;
using WeBGame.Models;

namespace WeBGame.Repositories
{
    public interface IGameRepository:IRepository<Game>
    {
        /// <summary>
        /// 获取所有游戏
        /// </summary>
        /// <returns>游戏实体列表，列表可能为NULL</returns>
        List<Game> GetAllGames();

        /// <summary>
        /// 获取游戏
        /// </summary>
        /// <param name="gameId">游戏ID</param>
        /// <returns>游戏实体，或者NULL</returns>
        Game GetGame(int gameId);
    }
}
