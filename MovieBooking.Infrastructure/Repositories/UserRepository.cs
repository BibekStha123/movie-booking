using Microsoft.EntityFrameworkCore;
using MovieBooking.Domain.Aggregates.Users;
using MovieBooking.Domain.Interfaces;
using MovieBooking.Infrastructure.Persistence;

namespace MovieBooking.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDBContext _dbContext;
        public UserRepository(ApplicationDBContext dBContext)
        {
            _dbContext = dBContext;
        }
        public async Task<User> CreateUserAsync(User user)
        {
            await _dbContext.User.AddAsync(user);
            await _dbContext.SaveChangesAsync();

            return user;
        }
        public Task<User?> GetByEmailAsync(string email)
        {
            return _dbContext.User.FirstOrDefaultAsync(x => x.Email == email);
        }
    }
}
