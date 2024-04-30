using May.The.Fourth.Backend.Domain.Model;

namespace May.The.Fourth.Backend.Data.Interfaces
{
    public interface IVehicleRepository
    {
        Task<IList<Vehicle>> GetVehiclesAsync();
        Task<Vehicle?> GetVehicleByIdAsync(int id);
    }
}