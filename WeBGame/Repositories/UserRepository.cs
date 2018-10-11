using System.Linq;
using WeBGame.Models;

namespace WeBGame.Repositories
{
    /// <summary>
    /// 用户仓储类
    /// </summary>
    public class UserRepository:RepositoryBase<User>, IUserRepository
    {
        public UserRepository(WbDbContext dbContext) : base(dbContext)
        {
        }

        public User GetUser(string username, string password)
        {
            return _dbContext.Set<User>().FirstOrDefault(it => it.UserName == username && it.Password == password);
        }
    }
}