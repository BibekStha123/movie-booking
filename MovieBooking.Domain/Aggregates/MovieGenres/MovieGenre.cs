using MovieBooking.Domain.Aggregates.Genres;
using MovieBooking.Domain.Aggregates.Movies;

namespace MovieBooking.Domain.Aggregates.MovieGenres
{
    public class MovieGenre
    {
        public MovieGenreId Id { get; set; }
        public MovieId MovieId { get; set; }
        public GenreId GenreId { get; set; }

        public static MovieGenre Create(MovieId movieId, GenreId genreId)
        {
            return new MovieGenre
            {
                Id = new MovieGenreId(Guid.NewGuid()),
                MovieId = movieId,
                GenreId = genreId
            };
        }
    }
}
