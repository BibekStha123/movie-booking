using MovieBooking.Domain.Aggregates.Users;

namespace MovieBooking.Domain.Interfaces
{
    public interface IUserRepository
    {
        Task<User?> GetByEmailAsync(string email);
        Task<User> CreateUserAsync(User user);
    }
}
