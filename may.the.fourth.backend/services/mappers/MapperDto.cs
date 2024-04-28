using May.The.Fourth.Backend.Data.Entities;

namespace May.The.Fourth.Backend.Services.Mappers
{
    public static class MapperDto
    {
        private static FilmeDto MapToFilmDto(FilmeEntity filme)
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

        private static PlanetDto MapToPlanetDto(PlanetEntity planet)
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

        private static VehicleDto MapToVehicleDto(VehicleEntity vehicle)
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
                MaxSpeed = vehicle.MaxSpeed,
                Crew = vehicle.Crew,
                Passengers = vehicle.Passengers,
                CargoCapacity = vehicle.CargoCapacity,
                Consumables = vehicle.Consumables,
                Class = vehicle.Class
            };
        }

        public static IList<VehicleDto> MapToVehicleDto(IList<VehicleEntity> vehicleEntities)
        {
            IList<VehicleDto> vehicles = new List<VehicleDto>();
            if (vehicleEntities.Any())
            {
                foreach (var vehicleEntity in vehicleEntities)
                    vehicles.Add(MapToVehicleDto(vehicleEntity));
            }
            return vehicles;
        }
    }
}