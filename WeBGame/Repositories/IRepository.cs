using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using WeBGame.Models;

namespace WeBGame.Repositories
{
    /// <summary>
    /// 仓储接口
    /// </summary>
    public interface IRepository
    {
        
    }

    /// <summary>
    /// 泛型仓储接口
    /// </summary>
    /// <typeparam name="TEntity">实体类型</typeparam>
    /// <typeparam name="TPrimaryKey">主键类型</typeparam>
    public interface IRepository<TEntity, TPrimaryKey> : IRepository where TEntity : Entity<TPrimaryKey>
    {
        /// <summary>
        /// 获取实体集合
        /// </summary>
        /// <returns></returns>
        List<TEntity> GetAllList();

        /// <summary>
        /// 根据 lambda 获取实体集合
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        List<TEntity> GetAllList(Expression<Func<TEntity, bool>> expression);

        /// <summary>
        /// 根据主键获取实体
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        TEntity GetEntity(TPrimaryKey id);

        /// <summary>
        /// 根据 lambda 获取单个实体
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        TEntity GetEntity(Expression<Func<TEntity, bool>> expression);

        /// <summary>
        /// 插入实体
        /// </summary>
        /// <param name="entity">实体</param>
        /// <returns></returns>
        TEntity Insert(TEntity entity);

        /// <summary>
        /// 更新实体
        /// </summary>
        /// <param name="entity">实体</param>
        /// <returns></returns>
        TEntity Update(TEntity entity);

        /// <summary>
        /// 插入或更新实体
        /// </summary>
        /// <param name="entity">实体</param>
        /// <returns></returns>
        TEntity InsertOrUpdate(TEntity entity);

        /// <summary>
        /// 删除实体
        /// </summary>
        /// <param name="entity">待删除实体</param>
        /// <returns></returns>
        void DeleteEntity(TEntity entity);

        /// <summary>
        /// 删除实体
        /// </summary>
        /// <param name="id">待删除实体的主键</param>
        /// <returns></returns>
        void DeleteEntity(TPrimaryKey id);
    }

    /// <summary>
    /// 默认Long类型主键仓储接口
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public interface IRepository<TEntity> : IRepository<TEntity, int> where TEntity : Entity { }
}