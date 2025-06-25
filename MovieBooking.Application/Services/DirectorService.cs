using MovieBooking.Application.DTO.Director;
using MovieBooking.Application.Interfaces;
using MovieBooking.Application.Mapper;
using MovieBooking.Domain.Aggregates.Directors;

namespace MovieBooking.Application.Services
{
    public class DirectorService : IDirectorService
    {
        private readonly IUnitOfWork _unitOfWork;
        public DirectorService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public Task<DirectorResponse> CreateAsyn(DirectorRequest director)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsyn()
        {
            throw new NotImplementedException();
        }

        public async Task<List<DirectorResponse>> GetAllAsyn()
        {
            var directors = await _unitOfWork.Director.GetAllAsync();
            return directors.Select(d => d.ToDirectorDTO()).ToList();
        }

        public Task<DirectorResponse> GetByIdAsyn(DirectorId directorId)
        {
            throw new NotImplementedException();
        }

        public Task<DirectorResponse> UpdateAsync(DirectorId directorId, DirectorRequest director)
        {
            throw new NotImplementedException();
        }
    }
}
