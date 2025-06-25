using Microsoft.AspNetCore.Mvc;
using MovieBooking.Application.Interfaces;

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

        public async Task<ActionResult> GetAllAsync()
        {
            var directors = await _directorService.GetAllAsyn();

            return Ok(directors);
        }
    }
}
