using MovieBooking.Domain.Aggregates.Movies;

namespace MovieBooking.Domain.Interfaces
{
    public interface IMovieRepository : IRepository<Movie, MovieId>
    {
    }
}
