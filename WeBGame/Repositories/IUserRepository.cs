using WeBGame.Models;

namespace WeBGame.Repositories
{
    public interface IUserRepository : IRepository<User>
    {
        /// <summary>
        /// 获取用户
        /// </summary>
        /// <param name="username">用户名</param>
        /// <param name="password">密码</param>
        /// <returns>用户实体或NULL</returns>
        User GetUser(string username, string password);

    }
}