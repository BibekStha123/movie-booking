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
        public async Task<DirectorResponse> CreateAsyn(DirectorRequest director)
        {
            var directorModel = Director.Create(
                    director.Name
            );

            await _unitOfWork.Director.CreateAsync(directorModel);
            await _unitOfWork.CompleteAsync();

            return directorModel.ToDirectorDTO();
        }
        public async Task<bool> DeleteAsyn(DirectorId directorId)
        {
            await _unitOfWork.Director.DeleteAsync(directorId);
            await _unitOfWork.CompleteAsync();

            return true;
        }
        public async Task<List<DirectorResponse>> GetAllAsyn()
        {
            var directors = await _unitOfWork.Director.GetAllAsync();
            return directors.Select(d => d.ToDirectorDTO()).ToList();
        }
        public async Task<DirectorResponse> GetByIdAsyn(DirectorId directorId)
        {
            var director = await _unitOfWork.Director.GetByIdAsync(directorId);
            return director.ToDirectorDTO();
        }
        public async Task<DirectorResponse> UpdateAsync(DirectorId directorId, DirectorRequest director)
        {
            var existingDirector = await _unitOfWork.Director.GetByIdAsync(directorId);

            existingDirector.Update(director.Name);

            await _unitOfWork.Director.UpdateAsync(existingDirector);
            await _unitOfWork.CompleteAsync();

            return existingDirector.ToDirectorDTO();
        }
    }
}
