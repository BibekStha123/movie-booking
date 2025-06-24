using MovieBooking.Application.DTO.Movie;
using MovieBooking.Domain.Aggregates.Movies;

namespace MovieBooking.Application.Interfaces
{
    public interface IMovieService
    {
        Task<List<MovieResponse>> GetAllAsync();
        Task<MovieResponse> GetByIdAsync(MovieId movieId);
        Task<MovieResponse> CreateAsync(MovieRequest movie);
        Task<bool> DeleteAsync(MovieId movieID);
    }
}
