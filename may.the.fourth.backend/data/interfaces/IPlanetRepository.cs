using May.The.Fourth.Backend.Domain.Model;

namespace May.The.Fourth.Backend.Data.Interfaces
{
    public interface IPlanetRepository
    {
        Task<IList<Planet>> GetPlanetsAsync();
        Task<Planet?> GetPlanetByIdAsync(int id);
    }
}