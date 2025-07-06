using MovieBooking.Domain.Aggregates.Cinemas;
using MovieBooking.Domain.Aggregates.Seats;

namespace MovieBooking.Domain.Aggregates.Theatres
{
    public class Theatre
    {
        public TheatreId Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int SeatCapacity { get; set; }
        public CinemaId CinemaId { get; set; }
        public Cinema Cinema { get; set; }
        public ICollection<Seat> Seats { get; set; } = new List<Seat>();

        public static Theatre Create(string name, int seatCapacity,  CinemaId cinemaId)
        {
            return new Theatre
            {
                Id = new TheatreId(Guid.NewGuid()),
                Name = name,
                SeatCapacity = seatCapacity,
                CinemaId = cinemaId,
            };
        }
    }
}
