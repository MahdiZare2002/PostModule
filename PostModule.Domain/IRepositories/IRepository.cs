using System.Linq.Expressions;

namespace PostModule.Domain.IRepositories
{
    public interface IRepository<TKey, TEntity> where TEntity : class
    {
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<IEnumerable<TEntity>> GetAllByAsync(Expression<Func<TEntity, bool>> expression);
        IQueryable<TEntity> GetAllByQuery(Expression<Func<TEntity, bool>> expression);
        IQueryable<TEntity> GetAllQuery();
        Task<TEntity> GetByIdAsync(TKey id);
        Task<bool> CreateAsync(TEntity entity);
        Task<bool> DeleteAsync(TEntity entity);
        Task<bool> IsExistAsync(Expression<Func<TEntity, bool>> expression);
        Task<bool> SaveAsync();
    }
}
