
using MovieBooking.Domain.Aggregates.Directors;

namespace MovieBooking.Domain.Interfaces
{
    public interface IDirectorRepository : IRepository<Director, DirectorId>
    {
    }
}
