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
            User user = _dbContext.Set<User>().FirstOrDefault(it => it.UserName == username && it.Password == password);
            if(user == null)
                user = _dbContext.Set<User>().FirstOrDefault(it => it.Email == username && it.Password == password);
            return user;
        }

        public void AddUser(User user)
        {
            Insert(user);
            Save();
        }
    }
}