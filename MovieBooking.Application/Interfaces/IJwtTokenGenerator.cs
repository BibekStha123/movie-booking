namespace MovieBooking.Application.Interfaces
{
    public interface IJwtTokenGenerator
    {
        string GenerateToken(string username, string role);
    }
}
