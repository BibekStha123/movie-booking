using MovieBooking.Application.DTO.Movie;
using MovieBooking.Application.Interfaces;
using MovieBooking.Application.Mapper;
using MovieBooking.Domain.Aggregates.Directors;
using MovieBooking.Domain.Aggregates.Movies;

namespace MovieBooking.Application.Services
{
    public class MovieService : IMovieService
    {
        private readonly IUnitOfWork _unitOfWork;
        public MovieService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<MovieResponse> CreateAsync(MovieRequest movie)
        {
            DirectorId directorId = new DirectorId(movie.DirectorId);//convert guid to directorID record
            var movieModel = Movie.Create(
                    movie.Title, 
                    movie.Description, 
                    directorId, 
                    movie.ReleaseDate, 
                    movie.RuntimeMinutes, 
                    movie.Status
            );

            await _unitOfWork.Movie.CreateAsync(movieModel);
            await _unitOfWork.CompleteAsync();

            return movieModel.ToMovieDTO();
        }

        public async Task<bool> DeleteAsync(MovieId movieID)
        {
            await _unitOfWork.Movie.DeleteAsync(movieID);
            await _unitOfWork.CompleteAsync();

            return true;
        }

        public async Task<List<MovieResponse>> GetAllAsync()
        {
            var movies = await _unitOfWork.Movie.GetAllAsync();
            return movies.Select(m => m.ToMovieDTO()).ToList();
        }

        public async Task<MovieResponse> GetByIdAsync(MovieId movieId)
        {
            var movie = await _unitOfWork.Movie.GetByIdAsync(movieId);
            return movie.ToMovieDTO();
        }

        public async Task<MovieResponse> UpdateAsync(MovieId movieId, MovieRequest request)
        {
            Movie existingMovie = await _unitOfWork.Movie.GetByIdAsync(movieId);

            DirectorId directorId = new DirectorId(request.DirectorId);//need to convert guid to DirectorId record
            existingMovie.Update(
                request.Title,
                request.Description,
                request.ReleaseDate,
                request.RuntimeMinutes,
                request.Status
            );

            existingMovie.UpdateDirector(directorId);

            await _unitOfWork.Movie.UpdateAsync(existingMovie);
            await _unitOfWork.CompleteAsync();

            return existingMovie.ToMovieDTO();
        }
    }
}
