using Microsoft.EntityFrameworkCore;
using MovieBooking.Domain.Aggregates.Movies;
using MovieBooking.Domain.Interfaces;
using MovieBooking.Infrastructure.Persistence;

namespace MovieBooking.Infrastructure.Repositories
{
    public class MovieRepository : Repository<Movie, MovieId>, IMovieRepository
    {
        private readonly ApplicationDBContext _dbContext;
        public MovieRepository(ApplicationDBContext dBContext) : base(dBContext) 
        {
            _dbContext = dBContext;
        }
        public async override Task<List<Movie>> GetAllAsync()
        {
            return await _dbContext.Movies.Include(m => m.Director).ToListAsync();
        }

        public async override Task<Movie> GetByIdAsync(MovieId movieId)
        {
            return await _dbContext.Movies.Include(m => m.Director).FirstOrDefaultAsync(m => m.Id == movieId) ?? 
                throw new Exception($"Movie does not exist with id {movieId}");
        }
    }
}
