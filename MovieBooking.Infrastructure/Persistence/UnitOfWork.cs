using MovieBooking.Application.Interfaces;
using MovieBooking.Domain.Interfaces;
using MovieBooking.Infrastructure.Repositories;

namespace MovieBooking.Infrastructure.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDBContext _dbContext;
        public IMovieRepository Movie { get; }
        public IDirectorRepository Director { get; }
        public IUserRepository User { get; }
        public IRoleRepository Role { get; }

        public UnitOfWork(ApplicationDBContext dBContext)
        {
            _dbContext = dBContext;
            Movie = new MovieRepository(_dbContext);
            Director = new DirectorRepository(_dbContext);
            User = new UserRepository(_dbContext);
            Role = new RoleRepository(_dbContext);
        }

        public async Task<int> CompleteAsync()
        {
            return await _dbContext.SaveChangesAsync();
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }
    }
}
