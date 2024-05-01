using May.The.Fourth.Backend.Domain.Model;

namespace May.The.Fourth.Backend.Data.Interfaces
{
    public interface IFilmRepository
    {
        Task<IList<Film>> GetFilmsAsync();

        Task<Film?> GetFilmByIdAsync(int id);
    }
}