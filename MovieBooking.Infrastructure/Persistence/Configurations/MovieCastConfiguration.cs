using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieBooking.Domain.Aggregates.MovieCasts;
using MovieBooking.Domain.Aggregates.Movies;
using MovieBooking.Domain.Aggregates.Casts;

namespace MovieBooking.Infrastructure.Persistence.Configurations
{
    internal class MovieCastConfiguration : IEntityTypeConfiguration<MovieCast>
    {
        public void Configure(EntityTypeBuilder<MovieCast> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasConversion(
                movieCastId => movieCastId.value,
                value => new MovieCastId(value));

            builder.Property(x => x.MovieId)
                .HasConversion(
                movieId => movieId.value,
                value => new MovieId(value))
                .IsRequired();

            builder.Property(x => x.CastId)
                .HasConversion(
                castId => castId.value,
                value => new CastId(value))
                .IsRequired();
        }
    }
}
