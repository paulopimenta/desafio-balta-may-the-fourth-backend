using Microsoft.EntityFrameworkCore;

using May.The.Fourth.Backend.Data.Contexts;
using May.The.Fourth.Backend.Data.Interfaces;
using May.The.Fourth.Backend.Domain.Model;

namespace May.The.Fourth.Backend.Data.Repositories
{
    public class VehicleRepository : IVehicleRepository
    {
        private readonly StarWarsContext ctx;

        public VehicleRepository(StarWarsContext ctx)
        {
            this.ctx = ctx;
        }

        public async Task<IList<Vehicle>> GetVehiclesAsync()
        {
            try
            {
                ctx.Database.EnsureCreated();
                IQueryable<Vehicle> vehicles = await Task.FromResult(ctx.Vehicles.Select(v => new Vehicle
                {
                    Id = v.Id,
                    Name = v.Name,
                    Model = v.Model,
                    Manufacturer = v.Manufacturer,
                    CostInCredits = v.CostInCredits,
                    Length = v.Length,
                    MaxAtmospheringSpeed = v.MaxAtmospheringSpeed,
                    Crew = v.Crew,
                    Passengers = v.Passengers,
                    CargoCapacity = v.CargoCapacity,
                    Consumables = v.Consumables,
                    Vehicle_Class = v.Vehicle_Class
                }));
                return vehicles.ToList();
            }
            catch (Exception e)
            {
                throw new Exception($"An error has occurred. Contact your admins and give them this reference: {e.StackTrace}");
            }
        }

        public async Task<Vehicle?> GetVehicleByIdAsync(int id)
        {
            try
            {
                var vehicle = await ctx.Vehicles
                    .Where(w => w.Id == id)
                    .Select(s => new Vehicle
                    {
                        Id = s.Id,
                        Name = s.Name,
                        Model = s.Model,
                        Manufacturer = s.Manufacturer,
                        CostInCredits = s.CostInCredits,
                        Length = s.Length,
                        MaxAtmospheringSpeed = s.MaxAtmospheringSpeed,
                        Crew = s.Crew,
                        Passengers = s.Passengers,
                        CargoCapacity = s.CargoCapacity,
                        Consumables = s.Consumables,
                        Vehicle_Class = s.Vehicle_Class
                    })
                    .FirstOrDefaultAsync();
                return vehicle;
            }
            catch(Exception e)
            {
                throw new Exception($"An error has occurred. Contact your admins and give them this reference: {e.StackTrace}");
            }
        }
    }
}