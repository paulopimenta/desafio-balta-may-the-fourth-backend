using May.The.Fourth.Backend.Services.Messages;

namespace May.The.Fourth.Backend.Services.Interfaces
{
    public interface IPlanetService
    {
        Task<PlanetListResponse> GetPlanetsAsync();
        Task<PlanetGetResponse> GetPlanetByIdAsync(int id);
    }
}