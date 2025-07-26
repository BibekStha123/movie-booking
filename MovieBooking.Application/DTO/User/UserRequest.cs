using System.ComponentModel.DataAnnotations;

namespace MovieBooking.Application.DTO.User
{
    public class UserRequest
    {
        [Required]
        public string Email { get; set; } = string.Empty;
        [Required]
        public string Password { get; set; } = string.Empty;
        [Required]
        public string Role {  get; set; } = string.Empty;
    }
}
