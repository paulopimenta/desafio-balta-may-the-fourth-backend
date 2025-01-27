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

        public static PlanetDto MapToPlanetDto(Planet planet)
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
                Population = planet.Population,
                CharactersDto = planet.Characters.Select(c => new CharacterDto { Id = c.Id, Name = c.Name }).ToList()
            };
        }

        public static IList<PlanetDto> MapToPlanetDto(IList<Planet> planets)
        {
            IList<PlanetDto> planetDtos = new List<PlanetDto>();
            if (planets.Any())
            {
                foreach (var planet in planets)
                    planetDtos.Add(MapToPlanetDto(planet));
            }
            return planetDtos;
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
                    Id = character.Planet!.Id,
                    Name = character.Planet.Name
                }
            };
        }

        public static IList<CharacterDto> MapToCharacterDto(IList<Character> characters)
        {
            IList<CharacterDto> characterDtos = new List<CharacterDto>();
            if (characters.Any())
            {
                foreach (var character in characters)
                    characterDtos.Add(MapToCharacterDto(character));
            }
            return characterDtos;
        }

        public static VehicleDto MapToVehicleDto(Vehicle vehicle)
        {
            if (vehicle == null)
                return new VehicleDto();
            return new VehicleDto
            {
                Id = vehicle.Id,
                Name = vehicle.Name,
                Model = vehicle.Model,
                Manufacturer = vehicle.Manufacturer,
                CostInCredits = vehicle.CostInCredits,
                Length = vehicle.Length,
                MaxAtmospheringSpeed = vehicle.MaxAtmospheringSpeed,
                Crew = vehicle.Crew,
                Passengers = vehicle.Passengers,
                CargoCapacity = vehicle.CargoCapacity,
                Consumables = vehicle.Consumables,
                VehicleClass = vehicle.VehicleClass
            };
        }

        public static IList<VehicleDto> MapToVehicleDto(IList<Vehicle> vehicles)
        {
            IList<VehicleDto> vehicleDtos = new List<VehicleDto>();
            if (vehicles.Any())
            {
                foreach (var vehicle in vehicles)
                    vehicleDtos.Add(MapToVehicleDto(vehicle));
            }
            return vehicleDtos;
        }

        public static StarshipDto MapToStarshipDto(Starship starship)
        {
            if (starship == null)
                return new StarshipDto();
            return new StarshipDto
            {
                Id = starship.Id,
                Name = starship.Name,
                Model = starship.Model,
                Manufacturer = starship.Manufacturer,
                CostInCredits = starship.CostInCredits,
                Length = starship.Length,
                MaxAtmospheringSpeed = starship.MaxAtmospheringSpeed,
                Crew = starship.Crew,
                Passengers = starship.Passengers,
                CargoCapacity = starship.CargoCapacity,
                Consumables = starship.Consumables,
                HyperdriveRating = starship.HyperdriveRating,
                MGLT = starship.MGLT,
                StarshipClass = starship.StarshipClass
            };
        }

        public static IList<StarshipDto> MapToStarshipDto(IList<Starship> starships)
        {
            IList<StarshipDto> starshipDtos = new List<StarshipDto>();
            if (starships.Any())
            {
                foreach (var starship in starships)
                    starshipDtos.Add(MapToStarshipDto(starship));
            }
            return starshipDtos;
        }
    }
}