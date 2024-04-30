using Microsoft.EntityFrameworkCore;

using May.The.Fourth.Backend.Data.Contexts;
using May.The.Fourth.Backend.Data.Interfaces;
using May.The.Fourth.Backend.Domain.Model;

namespace May.The.Fourth.Backend.Data.Repositories
{
    public class StarshipRepository : IStarshipRepository
    {
        private readonly StarWarsContext ctx;

        public StarshipRepository(StarWarsContext ctx)
        {
            this.ctx = ctx;
        }

        public async Task<IList<Starship>> GetStarshipsAsync()
        {
            try
            {
                ctx.Database.EnsureCreated();
                IQueryable<Starship> starships = await Task.FromResult(ctx.StarShips.Select(s => new Starship
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
                    HyperdriveRating = s.HyperdriveRating,
                    MGLT = s.MGLT,
                    StarshipClass = s.StarshipClass
                }));
                return starships.ToList();
            }
            catch (Exception e)
            {
                throw new Exception($"An error has occurred. Contact your admins and give them this reference: {e.StackTrace}");
            }
        }

        public async Task<Starship?> GetStarshipByIdAsync(int id)
        {
            try
            {
                var starship = await ctx.StarShips
                    .Where(w => w.Id == id)
                    .Select(s => new Starship
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
                        HyperdriveRating = s.HyperdriveRating,
                        MGLT = s.MGLT,
                        StarshipClass = s.StarshipClass
                    })
                    .FirstOrDefaultAsync();
                return starship;
            }
            catch(Exception e)
            {
                throw new Exception($"An error has occurred. Contact your admins and give them this reference: {e.StackTrace}");
            }
        }        
    }
}