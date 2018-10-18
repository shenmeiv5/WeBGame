using System.Collections.Generic;
using WeBGame.Models;

namespace WeBGame.Service
{
    /// <summary>
    /// 用户服务接口
    /// </summary>
    public interface IGameService
    {
        List<Game> GetGames();
        List<GameResource> GetResourcesForGame(int gameId);
        int GetPriceForGame(int gameId);
    }
}