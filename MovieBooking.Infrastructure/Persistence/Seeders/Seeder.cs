using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieBooking.Domain.Aggregates.Casts;
using MovieBooking.Domain.Aggregates.Cinemas;
using MovieBooking.Domain.Aggregates.Directors;
using MovieBooking.Domain.Aggregates.Genres;
using MovieBooking.Domain.Aggregates.Movies;
using MovieBooking.Domain.Aggregates.Seats;
using MovieBooking.Domain.Aggregates.States;
using MovieBooking.Domain.Aggregates.Theatres;

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

        public static void CastSeed(EntityTypeBuilder<Cast> builder)
        {
            builder.HasData(
                new { Id = new CastId(SeedIds.Cast_ChrisHemsworth), Name = "Chris Hemsworth" },
                new { Id = new CastId(SeedIds.Cast_TomHiddleston), Name = "Tom Hiddleston" },
                new { Id = new CastId(SeedIds.Cast_NataliePortman), Name = "Natalie Portman" },
                new { Id = new CastId(SeedIds.Cast_RobertDowneyJr), Name = "Robert Downey Jr." },
                new { Id = new CastId(SeedIds.Cast_ScarlettJohansson), Name = "Scarlett Johansson" }
            );
        }
        public static void StateSeed(EntityTypeBuilder<State> builder)
        {
            builder.HasData(
                new { Id = new StateId(SeedIds.State_NSW), Name = "NSW" },
                new { Id = new StateId(SeedIds.State_QLD), Name = "QLD" },
                new { Id = new StateId(SeedIds.State_WA), Name = "WA" },
                new { Id = new StateId(SeedIds.State_VIC), Name = "VIC" },
                new { Id = new StateId(SeedIds.State_SA), Name = "SA" }
            );
        }
        public static void CinemaSeed(EntityTypeBuilder<Cinema> builder)
        {
            builder.HasData(
                new { Id = new CinemaId(SeedIds.Cinema_EventAdelaide), Name = "Event Cinema Adelaide SA", StateId = new StateId(SeedIds.State_SA) },
                new { Id = new CinemaId(SeedIds.Cinema_HoytsMelbourne), Name = "Hoyts Melbourne Central VIC", StateId = new StateId(SeedIds.State_VIC) },
                new { Id = new CinemaId(SeedIds.Cinema_LunaPerth), Name = "Luna Cinemas Perth WA", StateId = new StateId(SeedIds.State_WA) }
            );
        }
        public static void TheatreSeed(EntityTypeBuilder<Theatre> builder)
        {
            builder.HasData(
                new { Id = new TheatreId(SeedIds.Theatre_EventTheatre1), Name = "Event Theatre 1a", SeatCapacity = 100, CinemaId = new CinemaId(SeedIds.Cinema_EventAdelaide) },
                new { Id = new TheatreId(SeedIds.Theatre_HoytsTheatre1), Name = "Hoyts Theatre 1a", SeatCapacity = 120, CinemaId = new CinemaId(SeedIds.Cinema_HoytsMelbourne) },
                new { Id = new TheatreId(SeedIds.Theatre_LunaTheatre1), Name = "Luna Theatre 1a", SeatCapacity = 80, CinemaId = new CinemaId(SeedIds.Cinema_LunaPerth) }
            );
        }
        public static void SeatSeed(EntityTypeBuilder<Seat> builder)
        {
            builder.HasData(
                new { Id = new SeatId(SeedIds.Seat_Event_Theatre1_SeatA1), SeatNo = "A1a", TheatreId = new TheatreId(SeedIds.Theatre_EventTheatre1) },
                new { Id = new SeatId(SeedIds.Seat_Event_Theatre1_SeatA2), SeatNo = "A2a", TheatreId = new TheatreId(SeedIds.Theatre_EventTheatre1) },

                new { Id = new SeatId(SeedIds.Seat_Hoyts_Theatre1_SeatA1), SeatNo = "B1b", TheatreId = new TheatreId(SeedIds.Theatre_HoytsTheatre1) },
                new { Id = new SeatId(SeedIds.Seat_Hoyts_Theatre1_SeatA2), SeatNo = "B2b", TheatreId = new TheatreId(SeedIds.Theatre_HoytsTheatre1) },

                new { Id = new SeatId(SeedIds.Seat_Luna_Theatre1_SeatA1),  SeatNo = "C1c", TheatreId = new TheatreId(SeedIds.Theatre_LunaTheatre1) },
                new { Id = new SeatId(SeedIds.Seat_Luna_Theatre1_SeatA2),  SeatNo = "C2c", TheatreId = new TheatreId(SeedIds.Theatre_LunaTheatre1) }
            );
        }
    }
}
