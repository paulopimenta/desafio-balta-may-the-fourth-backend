using May.The.Fourth.Backend.Services.Mappers;

namespace May.The.Fourth.Backend.Services.Messages
{
    public class StarshipGetResponse : ResponseBase
    {
        public StarshipDto? StarshipDto { get; set; }
    }
}