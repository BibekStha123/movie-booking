using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieBooking.Domain.Aggregates.Roles;
using MovieBooking.Domain.Aggregates.UserRoles;
using MovieBooking.Domain.Aggregates.Users;

namespace MovieBooking.Infrastructure.Persistence.Configurations
{
    internal class UserRoleConfiguration : IEntityTypeConfiguration<UserRole>
    {
        public void Configure(EntityTypeBuilder<UserRole> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).HasConversion(
                id => id.value,
                value => new UserRoleId(value))
                .ValueGeneratedNever()
                .IsRequired();

            builder.Property(ur => ur.UserId).HasConversion(
                id => id.value,
                value => new UserId(value))
                .IsRequired();

            builder.Property(ur => ur.RoleId).HasConversion(
                id => id.value, 
                value => new RoleId(value))
                .IsRequired();
        }
    }
}
