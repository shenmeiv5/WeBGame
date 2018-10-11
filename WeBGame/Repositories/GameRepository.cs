using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeBGame.Models;

namespace WeBGame.Repositories
{
    /// <summary>
    /// 游戏仓储类
    /// </summary>
    public class GameRepository : RepositoryBase<Game>, IGameRepository
    {
        public GameRepository(WbDbContext dbContext):base(dbContext)
        {

        }

        /// <summary>
        /// 获取所有游戏
        /// </summary>
        /// <returns>游戏实体列表，列表可能为null</returns>
        public List<Game> GetAllGames()
        {
            return GetAllList();
        }

        /// <summary>
        /// 获取游戏
        /// </summary>
        /// <returns></returns>
        public Game GetGame(int gameId)
        {
            return GetEntity(gameId);
        }

    }
}
