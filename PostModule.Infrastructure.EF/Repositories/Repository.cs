using Microsoft.EntityFrameworkCore;
using PostModule.Domain.IRepositories;
using System.Linq.Expressions;

namespace PostModule.Infrastructure.Repositories
{
    public class Repository<TKey, TEntity> : IRepository<TKey, TEntity> where TEntity : class
    {
        private readonly DbContext _context;
        public Repository(DbContext dbContext)
        {
            _context = dbContext;
        }
        public async Task<bool> CreateAsync(TEntity entity)
        {
            _context.Add<TEntity>(entity);
            return await SaveAsync();

        }

        public async Task<bool> DeleteAsync(TEntity entity)
        {
            _context.Remove<TEntity>(entity);
            return await SaveAsync();
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _context.Set<TEntity>().AsNoTracking().ToListAsync();
        }

        public async Task<IEnumerable<TEntity>> GetAllByAsync(Expression<Func<TEntity, bool>> expression)
        {
            return await _context.Set<TEntity>().Where(expression).ToListAsync();
        }

        public IQueryable<TEntity> GetAllByQuery(Expression<Func<TEntity, bool>> expression)
        {
            return _context.Set<TEntity>().Where(expression).AsQueryable();
        }

        public IQueryable<TEntity> GetAllQuery()
        {
            return _context.Set<TEntity>().AsQueryable();
        }

        public async Task<TEntity> GetByIdAsync(TKey id)
        {
            return await _context.FindAsync<TEntity>(id);
        }

        public async Task<bool> IsExistAsync(Expression<Func<TEntity, bool>> expression)
        {
            return await _context.Set<TEntity>().AnyAsync(expression);
        }

        public async Task<bool> SaveAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
