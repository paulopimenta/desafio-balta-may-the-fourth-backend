using May.The.Fourth.Backend.Services.Messages;

namespace May.The.Fourth.Backend.Services.Interfaces;

public interface IVehicleService
{
    Task<VehicleListResponse> GetVehicles();
}
