using MovieBooking.Domain.Aggregates.UserRoles;
using MovieBooking.Domain.Aggregates.Users;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieBooking.Domain.Aggregates.Roles
{
    public class Role
    {
        public RoleId Id { get; set; }
        public string Name { get; set; } = string.Empty;
        private readonly List<UserRole> _userRoles = new();
        public IReadOnlyCollection<UserRole> UserRoles => _userRoles.AsReadOnly();
        [NotMapped]
        public IEnumerable<User> Users => _userRoles.Select(u => u.User);
    }
}
