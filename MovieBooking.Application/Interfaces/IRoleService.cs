using MovieBooking.Domain.Aggregates.Roles;

namespace MovieBooking.Application.Interfaces
{
    public interface IRoleService
    {
        Task<Role> GetByNameAsync(string name);
    }
}
