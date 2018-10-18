using WeBGame.Models;

namespace WeBGame.Repositories
{
    public interface ISalesRepository:IRepository<GameSales>
    {
        GameSales GetSaleForGame(int gameId);
    }
}