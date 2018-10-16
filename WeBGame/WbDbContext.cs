using Microsoft.EntityFrameworkCore;
using WeBGame.Models;

namespace WeBGame
{
    /// <summary>
    /// 数据库上下文操作类
    /// </summary>
    public class WbDbContext:DbContext
    {
        public WbDbContext(DbContextOptions<WbDbContext> options):base(options)
        {

        }

        public DbSet<User> User { get; set; }
        public DbSet<Game> Game { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //关联配置
            base.OnModelCreating(modelBuilder);
        }
    }
}