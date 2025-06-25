using MovieBooking.Domain.Aggregates.Directors;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieBooking.Domain.Aggregates.Movies
{
    public class Movie
    {
        public MovieId Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get;  set; } = string.Empty;
        public DirectorId DirectorId { get;  set; }
        public Director Director { get; set; }
        public DateTime ReleaseDate { get;  set; }
        public int RuntimeMinutes { get;  set; }
        public MovieStatus Status { get;  set; }

        public static Movie Create(string title, string description, DirectorId directorId, DateTime releaseDate, int runtimeMinutes, MovieStatus status) 
        {
            validate(title, description, runtimeMinutes);
            var validatedStatus = ValidateMovieStatus(releaseDate, status);

            return new Movie
            {
                Id = new MovieId(Guid.NewGuid()),
                Title = title,
                Description = description,
                DirectorId = directorId,
                ReleaseDate = releaseDate,
                RuntimeMinutes = runtimeMinutes,
                Status = validatedStatus
            };
        }

        public void Update(string title, string description, DateTime releaseDate, int runtimeMinutes, MovieStatus status)
        {
            validate(title, description, runtimeMinutes);
            var validatedStatus = ValidateMovieStatus(releaseDate, status);
            //update the movie details
            Title = title;
            Description = description;
            ReleaseDate = releaseDate;
            RuntimeMinutes = runtimeMinutes;
            Status = validatedStatus;
        }

        public void UpdateDirector(DirectorId directorId)
        {
            if(directorId == null) throw new ArgumentNullException(nameof(directorId));

            DirectorId = directorId;
        }

        private static void validate(string title, string description, int runtimeMinutes)
        {
            if (string.IsNullOrWhiteSpace(title))
                throw new ArgumentNullException("Title is required", nameof(title));

            if (string.IsNullOrWhiteSpace(description))
                throw new ArgumentNullException("Description is required", nameof(description));

            if (runtimeMinutes <= 0)
                throw new ArgumentException("Runtime must be positive.", nameof(runtimeMinutes));
        }
         static MovieStatus ValidateMovieStatus(DateTime releaseDate, MovieStatus status)
        {
            var today = DateTime.UtcNow.Date;
            if (releaseDate > today && status != MovieStatus.Upcoming )
            {
                throw new Exception("For a future release date, status must be 'Upcoming'.");
            }

            if (releaseDate <= today && status == MovieStatus.Upcoming)
            {
                throw new Exception("For a past or current release date, status cannot be 'Upcoming'.");
            }

            return status;
        }
    }
}
