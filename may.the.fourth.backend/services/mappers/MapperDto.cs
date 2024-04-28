using May.The.Fourth.Backend.Data.Entities;
using May.The.Fourth.Backend.Domain.Model;

namespace May.The.Fourth.Backend.Services.Mappers
{
    public static class MapperDto
    {
        public static FilmeDto MapToFilmDto(FilmeEntity filme)
        {
            if (filme == null)
                return new FilmeDto();
            return new FilmeDto
            {
                Id = filme.Id,
                Titulo = filme.Titulo,
                Episodio = filme.Episodio,
                TextoAbertura = filme.TextoAbertura,
                Diretor = filme.Diretor,
                Produtor = filme.Produtor,
                DataLancamento = filme.DataLancamento
            };
        }

        public static IList<FilmeDto> MapToFilmDto(IList<FilmeEntity> filmeEntities)
        {
            IList<FilmeDto> filmes = new List<FilmeDto>();
            if (filmeEntities.Any())
            {
                foreach (var filmeEntity in filmeEntities)
                    filmes.Add(MapToFilmDto(filmeEntity));
            }
            return filmes;
        }

        public static PlanetDto MapToPlanetDto(PlanetEntity planet)
        {
            if (planet == null)
                return new PlanetDto();
            return new PlanetDto
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
                Population = planet.Population
            };
        }

        public static IList<PlanetDto> MapToPlanetDto(IList<PlanetEntity> planetEntities)
        {
            IList<PlanetDto> planets = new List<PlanetDto>();
            if (planetEntities.Any())
            {
                foreach (var planetEntity in planetEntities)
                    planets.Add(MapToPlanetDto(planetEntity));
            }
            return planets;
        }

        public static CharacterDto MapToCharacterDto(Character character)
        {
            if (character == null)
                return new CharacterDto();
            return new CharacterDto
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
                PlanetDto = new PlanetDto
                {
                    Id = character.Planet.Id,
                    Name = character.Planet.Name
                }
            };
        }

        public static IList<CharacterDto> MapToCharacterDto(IList<Character> characterEntities)
        {
            IList<CharacterDto> characters = new List<CharacterDto>();
            if (characterEntities.Any())
            {
                foreach (var characterEntity in characterEntities)
                    characters.Add(MapToCharacterDto(characterEntity));
            }
            return characters;
        }
    }
}