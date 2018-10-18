using System;
using WeBGame.Models;

namespace WeBGame.Repositories
{
    public class SalesRepository:RepositoryBase<GameSales>,ISalesRepository
    {
        public SalesRepository(WbDbContext dbContext) : base(dbContext)
        {
        }

        public GameSales GetSaleForGame(int gameId)
        {
            return GetEntity(it => it.Id == gameId);
        }
    }
}