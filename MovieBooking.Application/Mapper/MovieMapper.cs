using MovieBooking.Application.DTO.Director;
using MovieBooking.Application.DTO.Movie;
using MovieBooking.Domain.Aggregates.Movies;

namespace MovieBooking.Application.Mapper
{
    internal static class MovieMapper
    {
        public static MovieResponse ToMovieDTO(this Movie movie)
        {
            var director = movie.Director == null
                ? null
                : new BasicDirectorResponse
                {
                    Id = movie.DirectorId,
                    Name = movie.Director.Name
                };
            return new MovieResponse
            {
                Id = movie.Id,
                Title = movie.Title,
                Description = movie.Description,
                Director = director,
                ReleaseDate = movie.ReleaseDate,
                RuntimeMinutes = movie.RuntimeMinutes,
                Status = movie.Status.ToString()
            };
        }
    }
}
