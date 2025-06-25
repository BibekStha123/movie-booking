namespace MovieBooking.Domain.Aggregates.Genres
{
    public class Genre
    {
        public GenreId Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public static Genre Create(string name)
        {
            return new Genre
            {
                Id = new GenreId(Guid.NewGuid()),
                Name = name,
            };
        }
    }
}
