using MovieBooking.Domain.Aggregates.Genres;

namespace MovieBooking.Domain.Interfaces
{
    interface IGenreRepository : IRepository<Genre, GenreId>
    {
    }
}
