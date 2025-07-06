using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieBooking.Domain.Aggregates.Seats;
using MovieBooking.Domain.Aggregates.Theatres;

namespace MovieBooking.Infrastructure.Persistence.Configurations
{
    public class SeatConfiguration : IEntityTypeConfiguration<Seat>
    {
        public void Configure(EntityTypeBuilder<Seat> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id)
                .HasConversion(
                id => id.value,
                value => new SeatId(value))
                .ValueGeneratedNever()
                .IsRequired();

            builder.Property(e => e.SeatNo)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(e => e.TheatreId)
                .HasConversion(
                id => id.value,
                value => new TheatreId(value))
                .IsRequired();

            builder.HasOne(e => e.Theatre)
                .WithMany(t => t.Seats)
                .HasForeignKey("TheatreId")
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
