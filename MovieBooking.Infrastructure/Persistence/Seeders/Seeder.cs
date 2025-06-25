using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MovieBooking.Domain.Aggregates.Directors;
using MovieBooking.Domain.Aggregates.Genres;
using MovieBooking.Domain.Aggregates.Movies;

namespace MovieBooking.Infrastructure.Persistence.Seeders
{
    internal class Seeder
    {
        public static void DirectorSeed(EntityTypeBuilder<Director> builder)
        {
            builder.HasData(
                    new Director
                    {
                        Id = new DirectorId(SeedIds.Director_Nolan),
                        Name = "Christopher Nolan"
                    },
                    new Director
                    {
                        Id = new DirectorId(SeedIds.Director_Spielberg),
                        Name = "Steven Spielberg"
                    }
            );
        }

        public static void MovieSeed(EntityTypeBuilder<Movie> builder)
        {
            builder.HasData(
                new Movie
                {
                    Id = new MovieId(SeedIds.Movie_Inception),
                    Title = "Inception",
                    Description = "Mind-bending sci-fi thriller",
                    DirectorId = new DirectorId(SeedIds.Director_Nolan), // FK reference
                    ReleaseDate = new DateTime(2010, 7, 16),
                    RuntimeMinutes = 148,
                    Status = MovieStatus.Released
                },
                new Movie
                {
                    Id = new MovieId(SeedIds.Movie_Jaws),
                    Title = "Jaws",
                    Description = "Shark attack thriller",
                    DirectorId = new DirectorId(SeedIds.Director_Spielberg), // FK reference
                    ReleaseDate = new DateTime(1975, 6, 20),
                    RuntimeMinutes = 124,
                    Status = MovieStatus.Released
                }
            );
        }

        public static void GenreSeed(EntityTypeBuilder<Genre> builder)
        {
            builder.HasData(
                new { Id = new GenreId(SeedIds.Genre_Drama), Name = "Drama" },
                new { Id = new GenreId(SeedIds.Genre_Action), Name = "Action" },
                new { Id = new GenreId(SeedIds.Genre_Horror), Name = "Horror" },
                new { Id = new GenreId(SeedIds.Genre_LoveStory), Name = "Love Story" },
                new { Id = new GenreId(SeedIds.Genre_SciFi), Name = "Sci-Fi" },
                new { Id = new GenreId(SeedIds.Genre_Thriller), Name = "Thriller" }
            );
        }

    }
}
