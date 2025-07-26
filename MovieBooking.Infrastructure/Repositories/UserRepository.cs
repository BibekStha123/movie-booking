using Microsoft.EntityFrameworkCore;
using MovieBooking.Domain.Aggregates.Users;
using MovieBooking.Domain.Interfaces;
using MovieBooking.Infrastructure.Persistence;

namespace MovieBooking.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDBContext _dbContext;
        private readonly DbSet<User> _dbSet;
        public UserRepository(ApplicationDBContext dBContext)
        {
            _dbContext = dBContext;
            _dbSet = _dbContext.Set<User>();
        }
        public async Task<User> CreateUserAsync(User user)
        {
            await _dbSet.AddAsync(user);
            await _dbContext.SaveChangesAsync();

            return user;
        }
        public Task<User?> GetByEmailAsync(string email)
        {
            return _dbSet.FirstOrDefaultAsync(x => x.Email == email);
        }
    }
}
