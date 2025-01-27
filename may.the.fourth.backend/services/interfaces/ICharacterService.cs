using May.The.Fourth.Backend.Services.Messages;

namespace May.The.Fourth.Backend.Services.Interfaces
{
    public interface ICharacterService
    {
        Task<CharacterListResponse> GetCharactersAsync();
        Task<CharacterGetResponse> GetCharacterByIdAsync(int id);
    }
}