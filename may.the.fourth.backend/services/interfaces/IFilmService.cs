using May.The.Fourth.Backend.Services.Messages;

namespace May.The.Fourth.Backend.Services.Interfaces
{
    public interface IFilmService
    {
        Task<FilmListResponse> GetFilmsAsync();
        Task<FilmGetResponse> GetFilmByIdAsync(int id);
    }
}