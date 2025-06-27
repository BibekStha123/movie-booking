using MovieBooking.Application.DTO.Director;
using MovieBooking.Domain.Aggregates.Directors;

namespace MovieBooking.Application.Interfaces
{
    public interface IDirectorService
    {
        Task<List<DirectorResponse>> GetAllAsyn();
        Task<DirectorResponse> GetByIdAsyn(DirectorId directorId);
        Task <DirectorResponse> CreateAsyn(DirectorRequest director);
        Task<bool> DeleteAsyn(DirectorId directorId);
        Task<DirectorResponse> UpdateAsync(DirectorId directorId, DirectorRequest director);
    }
}
