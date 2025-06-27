using System.Linq.Expressions;

namespace PostModule.Domain.IRepositories
{
    public interface IRepository<TKey, TEntity> where TEntity : class
    {
        Task<IEnumerable<TKey>> GetAllAsync();
        Task<IEnumerable<TEntity>> FindAsync(Expression<Func<TEntity, bool>> expression);
        Task<TEntity> GetByIdAsync(TKey id);
        Task<bool> CreateAsync(TEntity entity);
        Task<bool> UpdateAsync(TEntity entity);
        Task<bool> DeleteAsync(TEntity entity);
        Task<bool> IsExist(Expression<Func<TEntity, bool>> expression);
    }
}
