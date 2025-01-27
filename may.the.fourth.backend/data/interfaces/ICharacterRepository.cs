using May.The.Fourth.Backend.Domain.Model;

namespace May.The.Fourth.Backend.Data.Interfaces
{
    public interface ICharacterRepository
    {
        Task<IList<Character>> GetCharactersAsync();
        Task<Character?> GetCharacterByIdAsync(int id);
    }
}