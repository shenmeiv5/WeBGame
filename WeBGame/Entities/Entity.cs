namespace WeBGame.Models
{
    /// <summary>
    /// 泛型实体基类
    /// </summary>
    /// <typeparam name="TPrimeKey">主键类型</typeparam>
    public abstract class Entity<TPrimeKey>
    {
        /// <summary>
        /// 主键
        /// </summary>
        public virtual TPrimeKey Id { get; set; }
    }

    /// <summary>
    /// 默认主键类型为int的实体基类
    /// </summary>
    public abstract class Entity:Entity<int>
    {

    }
}