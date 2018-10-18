using System;
using WeBGame.Models;

namespace WeBGame.Repositories
{
    public class SalesRepository:RepositoryBase<GameSales>,ISalesRepository
    {
        public SalesRepository(WbDbContext dbContext) : base(dbContext)
        {
        }

        public int GetPriceForGame(int gameId)
        {
            return (int)GetEntity(it => it.Id == gameId).SalePrice;
        }
    }
}