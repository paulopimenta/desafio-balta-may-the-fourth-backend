using May.The.Fourth.Backend.Services.Mappers;

namespace May.The.Fourth.Backend.Services.Messages
{
    public class PlanetListResponse : ResponseBase
    {
        public IList<PlanetDto>? PlanetDto { get; set; }
    }
}