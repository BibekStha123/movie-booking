
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieBooking.Domain.Aggregates.Cinemas;
using MovieBooking.Domain.Aggregates.States;

namespace MovieBooking.Infrastructure.Persistence.Configurations
{
    internal class CinemaConfiguration : IEntityTypeConfiguration<Cinema>
    {
        public void Configure(EntityTypeBuilder<Cinema> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).HasConversion(
                id => id.value,
                value => new CinemaId(value))
                .ValueGeneratedNever()
                .IsRequired();

            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(x => x.StateId)
                .HasConversion(
                id => id.value,
                value => new StateId(value))
                .IsRequired();

            builder.HasOne(x => x.State)
                .WithMany(s => s.Cinemas)
                .HasForeignKey("StateId")
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
