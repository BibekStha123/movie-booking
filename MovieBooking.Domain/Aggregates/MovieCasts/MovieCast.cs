using MovieBooking.Domain.Aggregates.Casts;
using MovieBooking.Domain.Aggregates.Movies;

namespace MovieBooking.Domain.Aggregates.MovieCasts
{
    public class MovieCast
    {
        public MovieCastId Id { get; set; }
        public MovieId MovieId { get; set; }
        public CastId CastId { get; set; }

        public static MovieCast Create(MovieId movieId, CastId castId)
        {
            return new MovieCast
            {
                Id = new MovieCastId(Guid.NewGuid()),
                MovieId = movieId,
                CastId = castId
            };
        }
    }
}
