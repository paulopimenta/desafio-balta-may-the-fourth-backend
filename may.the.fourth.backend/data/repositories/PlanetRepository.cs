using Microsoft.EntityFrameworkCore;

using May.The.Fourth.Backend.Data.Contexts;
using May.The.Fourth.Backend.Data.Interfaces;
using May.The.Fourth.Backend.Domain.Model;

namespace May.The.Fourth.Backend.Data.Repositories
{
    public class PlanetRepository : IPlanetRepository
    {
        private readonly StarWarsContext ctx;

        public PlanetRepository(StarWarsContext ctx)
        {
            this.ctx = ctx;
        }

        public async Task<IList<Planet>> GetPlanetsAsync()
        {
            try
            {
                ctx.Database.EnsureCreated();
                IQueryable<Planet> planets = await Task.FromResult(ctx.Planets.Include(p => p.Characters).Select(planet => new Planet
                {
                    Id = planet.Id,
                    Name = planet.Name,
                    RotationPeriod = planet.RotationPeriod,
                    OrbitalPeriod = planet.OrbitalPeriod,
                    Diameter = planet.Diameter,
                    Climate = planet.Climate,
                    Gravity = planet.Gravity,
                    Terrain = planet.Terrain,
                    SurfaceWater = planet.SurfaceWater,
                    Population = planet.Population,
                    Characters = planet.Characters
                        .Select(c => new Character{ Id = c.Id, Name = c.Name })
                        .OrderBy(o => o.Id)
                        .ToList()
                }));
                return planets.ToList();
            }
            catch (Exception e)
            {
                throw new Exception($"An error has occurred. Contact your admins and give them this reference: {e.StackTrace}");
            }
        }

        public async Task<Planet?> GetPlanetByIdAsync(int id)
        {
            try
            {
                var planet = await ctx.Planets
                    .Include(p => p.Characters)
                    .Where(w => w.Id == id)
                    .Select(s => new Planet
                    {
                        Id = s.Id,
                        Name = s.Name,
                        RotationPeriod = s.RotationPeriod,
                        OrbitalPeriod = s.OrbitalPeriod,
                        Diameter = s.Diameter,
                        Climate = s.Climate,
                        Gravity = s.Gravity,
                        Terrain = s.Terrain,
                        SurfaceWater = s.Terrain,
                        Population = s.Population,
                        Characters = s.Characters
                            .Select(c => new Character{ Id = c.Id, Name = c.Name })
                            .OrderBy(o => o.Id)
                            .ToList()
                    })
                    .FirstOrDefaultAsync();
                return planet;
            }
            catch(Exception e)
            {
                throw new Exception($"An error has occurred. Contact your admins and give them this reference: {e.StackTrace}");
            }
        }
    }
}