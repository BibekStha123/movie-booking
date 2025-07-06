using Microsoft.EntityFrameworkCore;
using MovieBooking.Domain.Aggregates.Casts;
using MovieBooking.Domain.Aggregates.Cinemas;
using MovieBooking.Domain.Aggregates.Directors;
using MovieBooking.Domain.Aggregates.Genres;
using MovieBooking.Domain.Aggregates.MovieCasts;
using MovieBooking.Domain.Aggregates.MovieGenres;
using MovieBooking.Domain.Aggregates.Movies;
using MovieBooking.Domain.Aggregates.Seats;
using MovieBooking.Domain.Aggregates.States;
using MovieBooking.Domain.Aggregates.Theatres;
using MovieBooking.Infrastructure.Persistence.Seeders;

namespace MovieBooking.Infrastructure.Persistence
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions options) : base(options) { }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<Cast> Casts { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<MovieCast> MovieCasts { get; set; }
        public DbSet<MovieGenre> MovieGenres { get; set; }
        public DbSet<State> State { get; set; }
        public DbSet<Cinema> Cinema { get; set; }
        public DbSet<Theatre> Theatre { get; set; }
        public DbSet<Seat> Seat { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDBContext).Assembly);
            base.OnModelCreating(modelBuilder);

            //seeder
            Seeder.DirectorSeed(modelBuilder.Entity<Director>());
            Seeder.MovieSeed(modelBuilder.Entity<Movie>());
            Seeder.GenreSeed(modelBuilder.Entity<Genre>());
            Seeder.CastSeed(modelBuilder.Entity<Cast>());
            Seeder.StateSeed(modelBuilder.Entity<State>());
            Seeder.CinemaSeed(modelBuilder.Entity<Cinema>());
            Seeder.TheatreSeed(modelBuilder.Entity<Theatre>());
            Seeder.SeatSeed(modelBuilder.Entity<Seat>());
        }

    }
}
