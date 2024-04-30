using May.The.Fourth.Backend.Data.Interfaces;
using May.The.Fourth.Backend.Services.Interfaces;
using May.The.Fourth.Backend.Services.Mappers;
using May.The.Fourth.Backend.Services.Messages;

namespace May.The.Fourth.Backend.Services
{
    public class CharacterService : ICharacterService
    {
        private readonly ICharacterRepository characterRepository;

        public CharacterService(ICharacterRepository characterRepository)
        {
            this.characterRepository = characterRepository;
        }

        public async Task<CharacterListResponse> GetCharactersAsync()
        {
            try
            {
                CharacterListResponse characterListResponse = new CharacterListResponse();
                var characters = await characterRepository.GetCharactersAsync();
                if (characters.Any())
                {
                    characterListResponse.Success = true;
                    characterListResponse.Message = "SUCCESS";
                    characterListResponse.StatusCode = 200;
                    characterListResponse.CharacterDtos = MapperDto.MapToCharacterDto(characters);
                }
                else
                {
                    characterListResponse.Success = false;
                    characterListResponse.Message = "FAILED";
                    characterListResponse.StatusCode = 500;
                    characterListResponse.CharacterDtos = null;
                }
                return characterListResponse;
            }
            catch(Exception)
            {
                return new CharacterListResponse
                {
                    Success = false,
                    Message = "Internal server error",
                    StatusCode = 500,
                    CharacterDtos = null
                };
            }
        }

        public async Task<CharacterGetResponse> GetCharacterByIdAsync(int id)
        {
            try
            {
                CharacterGetResponse characterGetResponse = new CharacterGetResponse();
                var character = await characterRepository.GetCharacterByIdAsync(id);
                if (character != null)
                {
                    characterGetResponse.Success = true;
                    characterGetResponse.Message = "SUCCESS";
                    characterGetResponse.StatusCode = 200;
                    characterGetResponse.CharacterDto = MapperDto.MapToCharacterDto(character);
                }
                else
                {
                    characterGetResponse.Success = false;
                    characterGetResponse.Message = "FAILED";
                    characterGetResponse.StatusCode = 500;
                    characterGetResponse.CharacterDto = null;
                }
                return characterGetResponse;
            }
            catch(Exception)
            {
                return new CharacterGetResponse
                {
                    Success = false,
                    Message = "Internal server error",
                    StatusCode = 500,
                    CharacterDto = null
                };
            }
        }
    }  
}