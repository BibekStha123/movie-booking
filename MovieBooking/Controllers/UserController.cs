using Microsoft.AspNetCore.Mvc;
using MovieBooking.Application.DTO.User;
using MovieBooking.Application.Interfaces;

namespace MovieBooking.Controllers
{
    [ApiController]
    [Route("api/")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IJwtTokenGenerator _jwtTokenGenerator;
        public UserController(IUserService userService, IJwtTokenGenerator jwtTokenGenerator)
        {
            _userService = userService;
            _jwtTokenGenerator = jwtTokenGenerator;
        }
        [HttpPost("register")]
        public async Task<ActionResult> Register([FromBody] UserRequest request)
        {
            var user = await _userService.CreateUserAsync(request.Email, request.Password, request.Role);
            return Ok( new
            {
                message = "User Created Successfully.",
                user
            });
        }
        [HttpPost("login")]
        public async Task<ActionResult> Login([FromBody] UserRequest request)
        {
            var user = await _userService.GetByEmailAsync(request.Email);
            var isValid = await _userService.ValidateCredentialAsync(request.Email, request.Password);

            if (!isValid) return Unauthorized(new { message = "Invalild Credentials" });

            var _token = _jwtTokenGenerator.GenerateToken(request.Email, "User");

            return Ok(new
            {
                message = "Login Successfull",
                _token,
                user
            });
        }
    }
}
