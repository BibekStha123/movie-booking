namespace MovieBooking.Domain.Aggregates.Casts
{
    public class Cast
    {
        public CastId Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public static Cast Create(string name)
        {
            return new Cast { 
                Id = new CastId(Guid.NewGuid()),
                Name = name 
            };
        }
    }
}
