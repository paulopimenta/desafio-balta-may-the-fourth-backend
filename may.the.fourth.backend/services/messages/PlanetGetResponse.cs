using May.The.Fourth.Backend.Services.Mappers;

namespace May.The.Fourth.Backend.Services.Messages
{
    public class PlanetGetResponse : ResponseBase
    {
        public PlanetDto? PlanetDto { get; set; }
    }
}