using MovieBooking.Application.Interfaces;
using MovieBooking.Domain.Aggregates.Users;
using System.Security.Cryptography;
using System.Text;

namespace MovieBooking.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;
        public UserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<User> CreateUserAsync(string email, string password)
        {
            var hash = HashPassword(password);
            User user = new User(email, hash);

            return await _unitOfWork.User.CreateUserAsync(user);
        }

        public async Task<User?> GetByEmailAsync(string email)
        {
            return await _unitOfWork.User.GetByEmailAsync(email);
        }
        public async Task<bool> ValidateCredentialAsync(string email, string password)
        {
            var user = await _unitOfWork.User.GetByEmailAsync(email);
            if (user == null) throw new Exception($"User does not exist with email {email}");

            var hashedPassword = HashPassword(password);
            return user.Password == hashedPassword;
        }
        private static string HashPassword(string password)
        {
            using var sha256 = SHA3_256.Create();
            var bytes = Encoding.UTF8.GetBytes(password);
            var hash = sha256.ComputeHash(bytes);

            return Convert.ToBase64String(hash);
        }

    }
}
