using MovieBooking.Domain.Aggregates.Theatres;

namespace MovieBooking.Domain.Aggregates.Seats
{
    public class Seat
    {
        public SeatId Id { get; set; }
        public string SeatNo { get; set; } = string.Empty;
        public TheatreId TheatreId { get; set; }
        public Theatre Theatre { get; set; }

        public static Seat Create(string seatNo, TheatreId theatreId)
        {
            return new Seat
            {
                Id = new SeatId(Guid.NewGuid()),
                SeatNo = seatNo,
                TheatreId = theatreId
            };
        }
    }
}
