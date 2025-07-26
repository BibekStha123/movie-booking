
using MovieBooking.Domain.Aggregates.Directors;

namespace MovieBooking.Application.DTO.Director
{
    public class BasicDirectorResponse
    {
        public DirectorId Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
