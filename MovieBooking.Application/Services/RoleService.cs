using MovieBooking.Application.Interfaces;
using MovieBooking.Domain.Aggregates.Roles;

namespace MovieBooking.Application.Services
{
    public class RoleService : IRoleService
    {
        private readonly IUnitOfWork _unitOfWork;
        public RoleService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<Role> GetByNameAsync(string name)
        {
            return await _unitOfWork.Role.GetByNameAsync(name) ?? throw new NotImplementedException($"{name} role does not exist.");
        }
    }
}
