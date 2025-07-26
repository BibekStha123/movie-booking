
using MovieBooking.Domain.Aggregates.Users;

namespace MovieBooking.Application.Interfaces
{
    public interface IUserService
    {
        Task<User?> GetByEmailAsync(string email);
        Task<User> CreateUserAsync(string email, string password, string Role);
        Task<bool> ValidateCredentialAsync(string email, string password);
    }
}
