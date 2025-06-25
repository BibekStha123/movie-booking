using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieBooking.Domain.Aggregates.Genres;
using MovieBooking.Domain.Aggregates.MovieGenres;
using MovieBooking.Domain.Aggregates.Movies;

namespace MovieBooking.Infrastructure.Persistence.Configurations
{
    internal class MovieGenreConfiguration : IEntityTypeConfiguration<MovieGenre>
    {
        public void Configure(EntityTypeBuilder<MovieGenre> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasConversion(
                movieCastId => movieCastId.value,
                value => new MovieGenreId(value));

            builder.Property(x => x.MovieId)
                .HasConversion(
                movieId => movieId.value,
                value => new MovieId(value))
                .IsRequired();

            builder.Property(x => x.GenreId)
                .HasConversion(
                castId => castId.value,
                value => new GenreId(value))
                .IsRequired();
        }
    }
}
