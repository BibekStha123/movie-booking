using MovieBooking.Domain.Aggregates.Roles;
using MovieBooking.Domain.Aggregates.Users;

namespace MovieBooking.Domain.Aggregates.UserRoles
{
    public class UserRole
    {
        public UserRoleId Id { get; set; }
        public UserId UserId { get; set; }
        public User User { get; set; }
        public RoleId RoleId { get; set; }
        public Role Role { get; set; }

        public UserRole(UserId userId, RoleId roleId)
        {
            UserId = userId;
            RoleId = roleId;
        }
    }
}
