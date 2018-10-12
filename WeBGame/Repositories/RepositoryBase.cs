using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using WeBGame;
using WeBGame.Models;
using WeBGame.Repositories;

namespace WeBGame.Repositories
{
    /// <summary>
    /// 仓储基类
    /// </summary>
    public abstract class RepositoryBase<TEntity, TPrimaryKey>:IRepository<TEntity, TPrimaryKey> where TEntity:Entity<TPrimaryKey>
    {
        /// <summary>
        /// 数据库访问上下文
        /// </summary>
        protected readonly WbDbContext _dbContext;

        protected RepositoryBase(WbDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public List<TEntity> GetAllList()
        {
            return _dbContext.Set<TEntity>().ToList();
        }

        public List<TEntity> GetAllList(Expression<Func<TEntity, bool>> expression)
        {
            return _dbContext.Set<TEntity>().Where(expression).ToList();
        }

        public TEntity GetEntity(TPrimaryKey id)
        {
            return _dbContext.Set<TEntity>().FirstOrDefault(CreateExpressionForId(id));
        }

        public TEntity GetEntity(Expression<Func<TEntity, bool>> expression)
        {
            return _dbContext.Set<TEntity>().Where(expression).FirstOrDefault();
        }

        public TEntity Insert(TEntity entity)
        {
            _dbContext.Set<TEntity>().Add(entity);
            return entity;
        }

        public TEntity Update(TEntity entity)
        {
            _dbContext.Set<TEntity>().Attach(entity);
            //标记该实体已被修改
            _dbContext.Entry(entity).State = EntityState.Modified;
            return entity;
        }

        public TEntity InsertOrUpdate(TEntity entity)
        {
            if (GetEntity(entity.Id) != null)
                return this.Update(entity);
            return this.Insert(entity);
        }

        public void DeleteEntity(TEntity entity)
        {
            _dbContext.Set<TEntity>().Remove(entity);
        }

        public void DeleteEntity(TPrimaryKey id)
        {
            _dbContext.Set<TEntity>().Remove(GetEntity(id));
        }

        /// <summary>
        /// 保存事务
        /// </summary>
        public void Save()
        {
            _dbContext.SaveChanges();
        }

        /// <summary>
        /// 根据主键创建 lambda 表达式
        /// </summary>
        /// <param name="id">主键</param>
        /// <returns></returns>
        protected static Expression<Func<TEntity, bool>> CreateExpressionForId(TPrimaryKey id)
        {
            var lambdaParm = Expression.Parameter(typeof(TEntity));
            var lambdaBody = Expression.Equal(
                Expression.PropertyOrField(lambdaParm, "Id"),
                Expression.Constant(id, typeof(TPrimaryKey))
            );

            return Expression.Lambda<Func<TEntity, bool>>(lambdaBody, lambdaParm);
        }
    }

}

public abstract class RepositoryBase<TEntity> : RepositoryBase<TEntity, int> where TEntity : Entity
{
    protected RepositoryBase(WbDbContext dbContext) : base(dbContext)
    {
    }
}