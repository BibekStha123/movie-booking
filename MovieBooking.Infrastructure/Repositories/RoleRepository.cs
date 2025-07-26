using Microsoft.EntityFrameworkCore;
using MovieBooking.Domain.Aggregates.Roles;
using MovieBooking.Domain.Interfaces;
using MovieBooking.Infrastructure.Persistence;

namespace MovieBooking.Infrastructure.Repositories
{
    public class RoleRepository : IRoleRepository
    {
        private readonly ApplicationDBContext _dbContext;
        public RoleRepository(ApplicationDBContext dBContext)
        {
            _dbContext = dBContext;
        }
        public async Task<Role?> GetByNameAsync(string name)
        {
            return await _dbContext.Role.FirstOrDefaultAsync(r => r.Name == name);
        }
    }
}
