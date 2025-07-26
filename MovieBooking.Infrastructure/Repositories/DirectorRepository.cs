using Microsoft.EntityFrameworkCore;
using MovieBooking.Domain.Aggregates.Directors;
using MovieBooking.Domain.Interfaces;
using MovieBooking.Infrastructure.Persistence;

namespace MovieBooking.Infrastructure.Repositories
{
    public class DirectorRepository : Repository<Director, DirectorId>, IDirectorRepository
    {
        private readonly ApplicationDBContext _dbContext;
        public DirectorRepository(ApplicationDBContext dBContext) : base(dBContext)
        { 
            _dbContext = dBContext;
        }

        public async override Task<List<Director>> GetAllAsync()
        {
            return await _dbContext.Directors.Include(d => d.Movies).ToListAsync();
        }
        public async override Task<Director> GetByIdAsync(DirectorId directorId)
        {
            return await _dbContext.Directors.Include(d => d.Movies).FirstOrDefaultAsync(d => d.Id == directorId) ?? new Director();
        }
    }
}
