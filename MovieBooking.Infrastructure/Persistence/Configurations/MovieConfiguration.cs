using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieBooking.Domain.Aggregates.Directors;
using MovieBooking.Domain.Aggregates.Movies;

namespace MovieBooking.Infrastructure.Persistence.Configurations
{
    internal class MovieConfiguration : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasConversion(
                id =>  id.value,
                value => new MovieId(value))
                .ValueGeneratedNever()
                .IsRequired();

            builder.Property(x => x.Title)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(x => x.Description)
                .HasMaxLength(200)
                .IsRequired();

            builder.Property(x => x.DirectorId)
                .HasConversion(
                id => id.value,
                value => new DirectorId(value))
                .IsRequired();

            builder.HasOne(x => x.Director)
                .WithMany(d => d.Movies)
                .HasForeignKey("DirectorId")
                .OnDelete(DeleteBehavior.Restrict);

            builder.Property(x => x.ReleaseDate)
                .IsRequired();

            builder.Property(x => x.RuntimeMinutes)
                .IsRequired();

            builder.Property(x => x.Status)
                .HasConversion<int>()
                .IsRequired();
        }
    }
}
