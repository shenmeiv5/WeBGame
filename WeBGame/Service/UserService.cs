using System;
using WeBGame.Models;
using WeBGame.Repositories;

namespace WeBGame.Service
{
    /// <summary>
    /// 用户服务类
    /// </summary>
    public class UserService:IUserService
    {
        private readonly IUserRepository _repository;

        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }


        public User GetUser(string username, string password)
        {
            return _repository.GetUser(username, password);
        }

        public void AddUser(User user)
        {
            user.CreateTime = user.LastLoginDateTime = DateTime.Now;
            user.Balance = 0;
            user.LoginTime = 0;
            _repository.AddUser(user);
        }
    }
}