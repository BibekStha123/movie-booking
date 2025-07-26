using MovieBooking.Domain.Aggregates.Roles;

namespace MovieBooking.Domain.Interfaces
{
    public interface IRoleRepository
    {
        Task<Role?> GetByNameAsync(string name);
    }
}
