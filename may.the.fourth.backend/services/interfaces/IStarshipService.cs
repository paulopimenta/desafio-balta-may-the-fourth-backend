using May.The.Fourth.Backend.Services.Messages;

namespace May.The.Fourth.Backend.Services.Interfaces
{
    public interface IStarshipService
    {
        Task<StarshipListResponse> GetStarshipsAsync();
        Task<StarshipGetResponse> GetStarshipByIdAsync(int id);
    }
}