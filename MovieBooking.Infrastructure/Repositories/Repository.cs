using Microsoft.EntityFrameworkCore;
using MovieBooking.Domain.Interfaces;
using MovieBooking.Infrastructure.Persistence;

namespace MovieBooking.Infrastructure.Repositories
{
    public class Repository<TEntity, TID> : IRepository<TEntity, TID> where TEntity : class
    {
        private readonly ApplicationDBContext _dBContext;
        private readonly DbSet<TEntity> _dbSet;
        public Repository(ApplicationDBContext dBContext)
        {
            _dBContext = dBContext;
            _dbSet = _dBContext.Set<TEntity>();
        }
        public async Task<TEntity> CreateAsync(TEntity entity)
        {
            await _dbSet.AddAsync(entity);
            await _dBContext.SaveChangesAsync();

            return entity;
        }
        public async Task<TEntity> DeleteAsync(TID id)
        {
            var entity = await _dbSet.FindAsync(id)
                        ?? throw new KeyNotFoundException($"Entity with ID {id} not found");

            _dbSet.Remove(entity);
            await _dBContext.SaveChangesAsync();

            return entity;
        }
        public virtual async Task<List<TEntity>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }
        public virtual async Task<TEntity> GetByIdAsync(TID id)
        {
            return await _dbSet.FindAsync(id) ?? throw new Exception($"Data does not exist with id {id}");
        }
        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            _dbSet.Update(entity);
            await _dBContext.SaveChangesAsync();

            return entity;
        }
    }
}
