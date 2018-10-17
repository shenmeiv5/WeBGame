using System.Collections.Generic;
using WeBGame.Models;

namespace WeBGame.Repositories
{
    public interface IGameResourceRepository:IRepository<GameResource>
    {
        List<GameResource> GetResources();

        List<GameResource> GetResourcesForGame(long gameID);
    }
}
