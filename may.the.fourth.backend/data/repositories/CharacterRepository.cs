using May.The.Fourth.Backend.Data.Contexts;
using May.The.Fourth.Backend.Data.Entities;
using May.The.Fourth.Backend.Data.Interfaces;
using May.The.Fourth.Backend.Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace May.The.Fourth.Backend.Data.Repositories
{
    public class CharacterRepository : ICharacterRepository
    {
        private readonly StarWarsContext ctx;

        public CharacterRepository(StarWarsContext ctx)
        {
            this.ctx = ctx;
        }

        public async Task<IList<Character>> GetCharacters()
        {
            try
            {
                ctx.Database.EnsureCreated();
                IQueryable<Character> characters = await Task.FromResult(ctx.Characters.Include(c => c.Planet).Select(character => new Character
                {
                    Id = character.Id,
                    Name = character.Name,
                    Height = character.Height,
                    Weight = character.Weight,
                    HairColor = character.HairColor,
                    SkinColor = character.SkinColor,
                    EyeColor = character.EyeColor,
                    BirthYear = character.BirthYear,
                    Gender = character.Gender,
                    Planet = new PlanetEntity { Id = character.Planet.Id, Name = character.Planet.Name } 
                })
                .OrderBy(o => o.Id));
                return characters.ToList();
            }
            catch (Exception e)
            {
                throw new Exception($"An error has occurred. Contact your admins and give them this reference: {e.StackTrace}");
            }
        }
    }
}