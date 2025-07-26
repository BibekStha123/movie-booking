using MovieBooking.Domain.Aggregates.Roles;
using MovieBooking.Domain.Aggregates.UserRoles;

namespace MovieBooking.Domain.Aggregates.Users
{
    public class User
    {
        public UserId Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        private readonly List<UserRole> _userRoles = new();
        public IReadOnlyCollection<UserRole> UserRoles => _userRoles.AsReadOnly();
        public IEnumerable<Role> Roles => _userRoles.Select(ur => ur.Role);
        public User(string email, string password)
        {
            Id = new UserId(Guid.NewGuid());
            Email = email;
            Password = password;
        }

        public void AddRole(Role role)
        {
            if (_userRoles.Any(ur => ur.RoleId == role.Id))
                return;

            UserRole userRole = new UserRole(Id, role.Id)
            {
                User = this,
                Role = role
            };

            _userRoles.Add(userRole);
        }
    }
}

