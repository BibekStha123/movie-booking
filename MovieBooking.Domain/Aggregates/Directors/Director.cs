using MovieBooking.Domain.Aggregates.Movies;
using System.ComponentModel.DataAnnotations;

namespace MovieBooking.Domain.Aggregates.Directors
{
    public class Director
    {
        public DirectorId Id { get; set; }
        public string Name { get; set; } = string.Empty;//need to make private setter

        private readonly List<Movie> _movies = new();
        public IReadOnlyList<Movie> Movies => _movies.ToList();

        public static Director Create(string name)
        {
            return new Director { 
                Id = new DirectorId(Guid.NewGuid()),
                Name = name 
            };
        }
        public void Update(string name)
        {
            Name = name;
        }

        public void AddMovie(string title, string description, DateTime releaseDate, int runtimeMinutes, MovieStatus status)
        {
            var movie = Movie.Create(title, description, Id, releaseDate, runtimeMinutes, status);
            _movies.Add(movie);
        }
    }
}
