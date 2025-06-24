using MovieBooking.Domain.Aggregates.Directors;
using MovieBooking.Domain.Aggregates.Movies;
using System.ComponentModel.DataAnnotations;

namespace MovieBooking.Application.DTO.Movie
{
    public class MovieRequest
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public Guid DirectorId { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int RuntimeMinutes { get; set; }
        public MovieStatus Status { get; set; }
    }
}