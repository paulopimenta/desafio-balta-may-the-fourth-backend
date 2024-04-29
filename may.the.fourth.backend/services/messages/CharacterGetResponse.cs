using May.The.Fourth.Backend.Services.Mappers;

namespace May.The.Fourth.Backend.Services.Messages
{
    public class CharacterGetResponse : ResponseBase
    {
        public CharacterDto? CharacterDto { get; set; }
    }
}