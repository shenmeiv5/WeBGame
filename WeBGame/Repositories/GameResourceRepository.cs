using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeBGame.Models;

namespace WeBGame.Repositories
{
    public class GameResourceRepository : RepositoryBase<GameResource>, IGameResourceRepository
    {
        public GameResourceRepository(WbDbContext dbContext):base(dbContext)
        {

        }


        public List<GameResource> GetResources()
        {
            return GetAllList();
        }

        public List<GameResource> GetResourcesForGame(long gameID)
        {
            return GetAllList(it => it.GameID == gameID);
        }
    }
}
