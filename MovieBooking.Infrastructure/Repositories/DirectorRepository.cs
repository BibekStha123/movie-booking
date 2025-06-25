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
    }
}
