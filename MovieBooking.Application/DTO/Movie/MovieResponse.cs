using MovieBooking.Application.DTO.Director;
using MovieBooking.Domain.Aggregates.Movies;

namespace MovieBooking.Application.DTO.Movie
{
    public class MovieResponse
    {
        public MovieId Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DirectorResponse? Director { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int RuntimeMinutes { get; set; }
        public string Status { get; set; } = string.Empty;
    }
}
