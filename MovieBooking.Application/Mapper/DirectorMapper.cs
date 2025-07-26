using MovieBooking.Application.DTO.Director;
using MovieBooking.Application.DTO.Movie;
using MovieBooking.Domain.Aggregates.Directors;

namespace MovieBooking.Application.Mapper
{
    internal static class DirectorMapper
    {
        public static DirectorResponse ToDirectorDTO(this Director model)
        {
            return new DirectorResponse
            {
                Id = model.Id,
                Name = model.Name,
                Movies = model.Movies.Select( m => new BasicMovieResponse
                {
                    Id = m.Id,
                    Title = m.Title,
                    Description = m.Description,
                    ReleaseDate = m.ReleaseDate,
                    RuntimeMinutes = m.RuntimeMinutes,
                    Status = m.Status.ToString()
                }).ToList()
            };
        }
    }
}
