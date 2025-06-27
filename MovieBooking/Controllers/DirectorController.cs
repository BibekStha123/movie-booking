using Microsoft.AspNetCore.Mvc;
using MovieBooking.Application.DTO.Director;
using MovieBooking.Application.Interfaces;
using MovieBooking.Domain.Aggregates.Directors;

namespace MovieBooking.Controllers
{
    [ApiController]
    [Route("api/directors")]
    public class DirectorController : ControllerBase
    {
        private readonly IDirectorService _directorService;
        public DirectorController(IDirectorService directorService)
        {
            _directorService = directorService;
        }
        [HttpGet]
        public async Task<ActionResult> GetAllAsync()
        {
            var directors = await _directorService.GetAllAsyn();

            return Ok(directors);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult> GetByIdAsync(Guid id)
        {
            DirectorId directorId = new DirectorId(id);
            var director = await _directorService.GetByIdAsyn(directorId);

            return Ok(director);
        }

        [HttpPost]
        public async Task<ActionResult> CreateAsync([FromForm] DirectorRequest request)
        {
            var director = await _directorService.CreateAsyn(request);

            return Ok(director);
        }
        [HttpPost("{id}")]
        public async Task<ActionResult> UpdateAsync(Guid id, [FromForm] DirectorRequest request)
        {
            DirectorId directorId = new DirectorId(id);

            var director = await _directorService.UpdateAsync(directorId, request);

            return Ok(director);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteAsync(Guid id)
        {
            DirectorId directorId = new DirectorId(id);
            await _directorService.DeleteAsyn(directorId);

            return Ok("Director deleted successfully.");
        }
    }
}
