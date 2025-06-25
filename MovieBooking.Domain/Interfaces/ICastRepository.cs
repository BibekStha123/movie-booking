using MovieBooking.Domain.Aggregates.Casts;

namespace MovieBooking.Domain.Interfaces
{
    public interface ICastRepository : IRepository<Cast, CastId>
    {
    }
}
