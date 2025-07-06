using MovieBooking.Domain.Aggregates.States;
using MovieBooking.Domain.Aggregates.Theatres;

namespace MovieBooking.Domain.Aggregates.Cinemas
{
    public class Cinema
    {
        public CinemaId Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public StateId StateId { get; set; }
        public State State { get; set; }
        public ICollection<Theatre> Theatres = new List<Theatre>();

        public static Cinema Create(string name, StateId stateId)
        {
            return new Cinema 
            { 
                Id = new CinemaId(Guid.NewGuid()),
                Name = name, 
                StateId = stateId 
            };
        }
    }
}
