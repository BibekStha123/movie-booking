using MovieBooking.Application.DTO.Movie;
using MovieBooking.Domain.Aggregates.Directors;

namespace MovieBooking.Application.DTO.Director
{
    public class DirectorResponse
    {
        public DirectorId Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public IReadOnlyList<BasicMovieResponse> Movies { get; set; } = new List<BasicMovieResponse>();
    }
}
