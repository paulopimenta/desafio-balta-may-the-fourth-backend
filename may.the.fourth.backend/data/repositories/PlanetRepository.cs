using May.The.Fourth.Backend.Data.Contexts;
using May.The.Fourth.Backend.Data.Entities;
using May.The.Fourth.Backend.Data.Interfaces;

namespace May.The.Fourth.Backend.Data.Repositories
{
    public class PlanetRepository : IPlanetRepository
    {
        private readonly StarWarsContext ctx;

        public PlanetRepository(StarWarsContext ctx)
        {
            this.ctx = ctx;
        }

        public async Task<IList<PlanetEntity>> GetPlanets()
        {
            try
            {
                IQueryable<PlanetEntity> planets = await Task.FromResult(ctx.Planets);
                return planets.ToList();
            }
            catch (Exception e)
            {
                throw new Exception($"An error has occurred. Contact your admins and give them this reference: {e.StackTrace}");
            }
        }
    }
}