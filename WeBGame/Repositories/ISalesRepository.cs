using WeBGame.Models;

namespace WeBGame.Repositories
{
    public interface ISalesRepository:IRepository<GameSales>
    {
        int GetPriceForGame(int gameId);
    }
}