using May.The.Fourth.Backend.Data.Entities;

namespace May.The.Fourth.Backend.Data.Interfaces;

public interface IVehicleRepository
{
    Task<IList<VehicleEntity>> GetVehicles();
}
