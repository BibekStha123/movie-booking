using Microsoft.AspNetCore.Mvc;
using MovieBooking.Application.DTO.Movie;
using MovieBooking.Application.Interfaces;
using MovieBooking.Domain.Aggregates.Movies;
using System.Net.Http;

namespace MovieBooking.Controllers
{
    [ApiController]
    [Route("api/movies")]
    public class MovieController : ControllerBase
    {
        private readonly IMovieService _movieService;

        public MovieController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        [HttpPost]
        public async Task<ActionResult> CreateAsync([FromForm]MovieRequest request)
        {
            var movie = await _movieService.CreateAsync(request);
            return Ok(movie);
        }

        [HttpGet]
        public async Task<ActionResult> GetAllAsync()
        {
            var movies = await _movieService.GetAllAsync();
            return Ok(movies);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetByIdAsync(Guid id)
        {
            MovieId movieId = new MovieId(id);
            var movie = await _movieService.GetByIdAsync(movieId);
            if (movie == null)
            {
                return NotFound();
            }

            return Ok(movie);
        }

        [HttpPost("{id}")]
        public async Task<ActionResult> UpdateAsync(Guid id, [FromForm]MovieRequest request)
        {
            MovieId movieId = new MovieId(id);
            var movie = await _movieService.UpdateAsync(movieId, request);

            return Ok(movie);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            MovieId movieId = new MovieId(id);

            await _movieService.DeleteAsync(movieId);

            return Ok("Movie Deleted Successfully");
        }
    }
}
