using May.The.Fourth.Backend.Data.Contexts;
using May.The.Fourth.Backend.Data.Entities;
using May.The.Fourth.Backend.Data.Interfaces;

namespace May.The.Fourth.Backend.Data.Repositories;

public class VehicleRepository: IVehicleRepository
{
    private readonly StarWarsContext ctx;

    public VehicleRepository(StarWarsContext ctx)
    {
        this.ctx = ctx;
    }

    public async Task<IList<VehicleEntity>> GetVehicles()
    {
        try
        {
            IQueryable<VehicleEntity> vehicles = await Task.FromResult(ctx.Vehicles);
            return vehicles.ToList();
        }
        catch (Exception e)
        {
            throw new Exception($"An error has occurred. Contact your admins and give them this reference: {e.StackTrace}");
        }
    }
}