using MovieBooking.Domain.Aggregates.Users;

namespace MovieBooking.Domain.Interfaces
{
    public interface IUserRepository : IRepository<User, UserId>
    {
        Task<User> GetByEmailAsync(string email);
    }
}
