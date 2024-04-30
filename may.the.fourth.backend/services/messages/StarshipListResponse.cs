using May.The.Fourth.Backend.Services.Mappers;

namespace May.The.Fourth.Backend.Services.Messages
{
    public class StarshipListResponse : ResponseBase
    {
        public IList<StarshipDto>? StarshipDtos { get; set; }
    }
}