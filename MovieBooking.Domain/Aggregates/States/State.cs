using MovieBooking.Domain.Aggregates.Cinemas;

namespace MovieBooking.Domain.Aggregates.States
{
    public class State
    {
        public StateId Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public ICollection<Cinema> Cinemas = new List<Cinema>();
        public static State Create(string name)
        {
            return new State
            {
                Id = new StateId(Guid.NewGuid()),
                Name = name
            };
        }
    }
}
