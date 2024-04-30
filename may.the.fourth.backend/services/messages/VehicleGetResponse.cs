using May.The.Fourth.Backend.Services.Mappers;

namespace May.The.Fourth.Backend.Services.Messages
{
    public class VehicleGetResponse : ResponseBase
    {
        public VehicleDto? VehicleDto { get; set; }
    }
}