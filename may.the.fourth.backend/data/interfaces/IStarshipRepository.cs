using May.The.Fourth.Backend.Domain.Model;

namespace May.The.Fourth.Backend.Data.Interfaces
{
    public interface IStarshipRepository
    {
        Task<IList<Starship>> GetStarshipsAsync();
        Task<Starship?> GetStarshipByIdAsync(int id);
    }
}