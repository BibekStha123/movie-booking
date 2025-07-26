using MovieBooking.Domain.Aggregates.Movies;

namespace MovieBooking.Application.DTO.Movie
{
    public class BasicMovieResponse
    {
        public MovieId Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime ReleaseDate { get; set; }
        public int RuntimeMinutes { get; set; }
        public string Status { get; set; } = string.Empty;
    }
}
