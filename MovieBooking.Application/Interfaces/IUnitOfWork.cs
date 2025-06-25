using MovieBooking.Domain.Interfaces;

namespace MovieBooking.Application.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        public IMovieRepository Movie {  get; }
        public IDirectorRepository Director { get; }
        Task<int> CompleteAsync();
    }
}
