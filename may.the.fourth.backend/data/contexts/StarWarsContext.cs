using Microsoft.EntityFrameworkCore;

using May.The.Fourth.Backend.Data.Entities;

namespace May.The.Fourth.Backend.Data.Contexts
{
    public class StarWarsContext : DbContext
    {        
        public StarWarsContext(DbContextOptions<StarWarsContext> options)
            : base(options) { }

        public DbSet<FilmeEntity> Filmes { get; set; }
        public DbSet<PlanetEntity> Planets { get; set; }
        public DbSet<FilmPlanetEntity> FilmsPlanets { get; set; }
        public DbSet<VehicleEntity> Vehicles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // filmes
            var filmes = new FilmeEntity[]
            {
                new FilmeEntity { Id = 1, Titulo = "The Rise of the Jedi", Episodio = 10, TextoAbertura = "After the fall of the Empire, the galaxy face", Diretor = "Jana Doe", Produtor = "Leo Smith", DataLancamento = new DateTime(2028, 12, 15) },
                new FilmeEntity { Id = 2, Titulo = "The Battle of the Stars" },
                new FilmeEntity { Id = 3, Titulo = "Return of the Light" },
                new FilmeEntity { Id = 4, Titulo = "Warriors of the Shadow Realm" },
                new FilmeEntity { Id = 5, Titulo = "The Galactic Quest" },
                new FilmeEntity { Id = 6, Titulo = "Rise of the Planetara" },
                new FilmeEntity { Id = 7, Titulo = "Echoes of the Stars" },
                new FilmeEntity { Id = 8, Titulo = "The Return of the Voyager" },
                new FilmeEntity { Id = 9, Titulo = "Voyager's Endgame" },
                new FilmeEntity { Id = 10, Titulo = "Galactic Odyssey" },
                new FilmeEntity { Id = 11, Titulo = "The Edge of the Universe" }
            };
            modelBuilder.Entity<FilmeEntity>().HasData(filmes);

            // planets
            var planets = new PlanetEntity[]
            {
                new PlanetEntity { Id = 1, Name = "Tatooine", RotationPeriod = "23", OrbitalPeriod = "304", Diameter = "10465", Climate = "arid", Gravity = "1 standard", Terrain = "desert", SurfaceWater = "1", Population = "200000" },
                new PlanetEntity { Id = 2, Name = "Alderaan", RotationPeriod = "24", OrbitalPeriod = "364", Diameter = "12500", Climate = "temperate", Gravity = "1 standard", Terrain = "grasslands, mountains", SurfaceWater = "40", Population = "2000000000" },
                new PlanetEntity { Id = 3, Name = "Yavin IV", RotationPeriod = "24", OrbitalPeriod = "4818", Diameter = "10200", Climate = "temperate, tropical", Gravity = "1 standard", Terrain = "jungle, rainforests", SurfaceWater = "8", Population = "1000" },
                new PlanetEntity { Id = 4, Name = "Hoth", RotationPeriod = "23", OrbitalPeriod = "549", Diameter = "7200", Climate = "frozen", Gravity = "1.1 standard", Terrain = "tundra, ice caves, mountain ranges", SurfaceWater = "100", Population = "unknown" },
                new PlanetEntity { Id = 5, Name = "Dagobah", RotationPeriod = "23", OrbitalPeriod = "341", Diameter = "8900", Climate = "murky", Gravity = "N/A", Terrain = "swamp, jungles", SurfaceWater = "8", Population = "unknown" },
                new PlanetEntity { Id = 6, Name = "Bespin", RotationPeriod = "12", OrbitalPeriod = "5110", Diameter = "118000", Climate = "temperate", Gravity = "1.5 (surface), 1 standard (Cloud City)", Terrain = "gas giant", SurfaceWater = "0", Population = "6000000" },
                new PlanetEntity { Id = 7, Name = "Endor", RotationPeriod = "18", OrbitalPeriod = "402", Diameter = "4900", Climate = "temperate", Gravity = "0.85 standard", Terrain = "forests, mountains, lakes", SurfaceWater = "8", Population = "30000000" },
                new PlanetEntity { Id = 8, Name = "Naboo", RotationPeriod = "26", OrbitalPeriod = "312", Diameter = "12120", Climate = "temperate", Gravity = "1 standard", Terrain = "grassy hills, swamps, forests, mountains", SurfaceWater = "12", Population = "4500000000" },
                new PlanetEntity { Id = 9, Name = "Coruscant", RotationPeriod = "24", OrbitalPeriod = "368", Diameter = "12240", Climate = "temperate", Gravity = "1 standard", Terrain = "cityscape, mountains", SurfaceWater = "unknown", Population = "1000000000000" },
                new PlanetEntity { Id = 10, Name = "Kamino", RotationPeriod = "27", OrbitalPeriod = "463", Diameter = "19720", Climate = "temperate", Gravity = "1 standard", Terrain = "ocean", SurfaceWater = "100", Population = "1000000000" }
            };
            modelBuilder.Entity<PlanetEntity>().HasData(planets);

            // films-planets
            var filmsPlanets = new FilmPlanetEntity[]
            {
                new FilmPlanetEntity { PlanetId = 1 },
                new FilmPlanetEntity { PlanetId = 2 },
                new FilmPlanetEntity { PlanetId = 3 },
                new FilmPlanetEntity { PlanetId = 4 },
                new FilmPlanetEntity { PlanetId = 5 },
                new FilmPlanetEntity { PlanetId = 6 },
                new FilmPlanetEntity { PlanetId = 7 },
                new FilmPlanetEntity { PlanetId = 8 },
                new FilmPlanetEntity { PlanetId = 9 },
                new FilmPlanetEntity { PlanetId = 10 }
            };
            modelBuilder.Entity<FilmPlanetEntity>().HasData(filmsPlanets);

            // vehicles
            var vehicles = new VehicleEntity[]
            {
                new VehicleEntity { Id = 4, Name = "Sand Crawler", Model = "Digger Crawler", Manufacturer = "Corellia Mining Corporation", CostInCredits = "150000", Length = "36.8", MaxSpeed = "30", Crew = "46", Passengers = "30", CargoCapacity = "50000", Consumables = "2 months", Class = "wheeled" },
                new VehicleEntity { Id = 6, Name = "T-16 skyhopper", Model = "T-16 skyhopper", Manufacturer = "Incom Corporation", CostInCredits = "14500", Length = "10.4", MaxSpeed = "1200", Crew = "1", Passengers = "1", CargoCapacity = "50", Consumables = "0", Class= "repulsorcraft" },
                new VehicleEntity { Id = 7, Name = "X-34 landspeeder", Model = "X-34 landspeeder", Manufacturer = "SoroSuub Corporation", CostInCredits = "10550", Length = "3.4", MaxSpeed = "250", Crew = "1", Passengers = "1", CargoCapacity = "5", Consumables = "unknown", Class = "repulsorcraft" },
                new VehicleEntity { Id = 8, Name = "TIE/LN starfighter", Model = "Twin Ion Engine/Ln Starfighter", Manufacturer = "Sienar Fleet Systems", CostInCredits = "unknown", Length = "6.4", MaxSpeed = "1200", Crew = "1", Passengers = "0", CargoCapacity = "65", Consumables = "2 days", Class = "starfighter" },                
                new VehicleEntity { Id = 14, Name = "Snowspeeder", Model = "t-47 airspeeder", Manufacturer = "Incom corporation", CostInCredits = "unknown", Length = "4.5", MaxSpeed = "650", Crew = "2", Passengers = "0", CargoCapacity = "10", Consumables = "none", Class = "airspeeder" },
                new VehicleEntity { Id = 16, Name = "TIE bomber", Model = "TIE/sa bomber", Manufacturer = "Sienar Fleet Systems", CostInCredits = "unknown", Length = "7.8", MaxSpeed = "850", Crew = "1", Passengers = "0", CargoCapacity = "none", Consumables = "2 days", Class = "space/planetary bomber" },
                new VehicleEntity { Id = 18, Name = "AT-AT", Model = "All Terrain Armored Transport", Manufacturer = "Kuat Drive Yards, Imperial Department of Military Research", CostInCredits = "unknown", Length = "20", MaxSpeed = "60", Crew = "5", Passengers = "40", CargoCapacity = "1000", Consumables = "unknown", Class = "assault walker" },
                new VehicleEntity { Id = 19, Name = "AT-ST", Model = "All Terrain Scout Transport", Manufacturer = "Kuat Drive Yards, Imperial Department of Military Research", CostInCredits = "unknown", Length = "2", MaxSpeed = "90", Crew = "2", Passengers = "0", CargoCapacity = "200", Consumables = "none", Class = "walker" },
                new VehicleEntity { Id = 20, Name = "Storm IV Twin-Pod cloud car", Model = "Storm IV Twin-Pod", Manufacturer = "Bespin Motors", CostInCredits = "75000", Length = "7", MaxSpeed = "1500", Crew = "2", Passengers = "0", CargoCapacity = "10", Consumables = "1 day", Class = "repulsorcraft" },
                new VehicleEntity { Id = 24, Name = "Sail barge", Model = "Modified Luxury Sail Barge", Manufacturer = "Ubrikkian Industries Custom Vehicle Division", CostInCredits = "285000", Length = "30", MaxSpeed = "100", Crew = "26", Passengers = "500", CargoCapacity = "2000000", Consumables = "Live food tanks", Class = "sail barge" }
            };
            modelBuilder.Entity<VehicleEntity>().HasData(vehicles);
        }
    }
}