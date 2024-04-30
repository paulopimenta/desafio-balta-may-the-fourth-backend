using May.The.Fourth.Backend.Services.Mappers;

namespace May.The.Fourth.Backend.Services.Messages
{
    public class VehicleListResponse : ResponseBase
    {
        public IList<VehicleDto>? VehicleDtos { get; set; }
    }
}