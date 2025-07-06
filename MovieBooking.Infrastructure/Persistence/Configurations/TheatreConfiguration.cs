using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieBooking.Domain.Aggregates.Cinemas;
using MovieBooking.Domain.Aggregates.Theatres;

namespace MovieBooking.Infrastructure.Persistence.Configurations
{
    internal class TheatreConfiguration : IEntityTypeConfiguration<Theatre>
    {
        public void Configure(EntityTypeBuilder<Theatre> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasConversion(
                id => id.value,
                value => new TheatreId(value))
                .ValueGeneratedNever()
                .IsRequired();

            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(x => x.SeatCapacity)
                .IsRequired();

            builder.Property(x => x.CinemaId)
                .HasConversion(
                id => id.value,
                value => new CinemaId(value))
                .IsRequired();

            builder.HasOne(x => x.Cinema)
                .WithMany(c => c.Theatres)
                .HasForeignKey("CinemaId")
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
