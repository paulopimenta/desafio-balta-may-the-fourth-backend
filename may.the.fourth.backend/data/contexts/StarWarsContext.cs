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
        public DbSet<CharacterEntity> Characters { get; set; }
        public DbSet<VehicleEntity> Vehicles { get; set; }
        public DbSet<StarshipEntity> StarShips { get; set; }

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
            modelBuilder.Entity<PlanetEntity>().HasData(
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
            );

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

            // characters
            modelBuilder.Entity<CharacterEntity>().HasData(
                new CharacterEntity { Id = 1, Name = "Luke Skywalker", Height = "172", Weight = "77", HairColor = "blond", SkinColor = "fair", EyeColor = "blue", BirthYear = "19BBY", Gender = "male", PlanetId = 1 },
                new CharacterEntity { Id = 2, Name = "C-3PO", Height = "167", Weight = "75", HairColor = "n/a", SkinColor = "gold", EyeColor = "yellow", BirthYear = "112BBY", Gender = "n/a", PlanetId = 1 },
                new CharacterEntity { Id = 3, Name = "R2-D2", Height = "96", Weight = "32", HairColor = "n/a", SkinColor = "white, blue", EyeColor = "red", BirthYear = "33BBY", Gender = "n/a", PlanetId = 8 },
                new CharacterEntity { Id = 4, Name = "Darth Vader", Height = "202", Weight = "136", HairColor = "none", SkinColor = "white", EyeColor = "yellow", BirthYear = "41.9BBY", Gender = "male", PlanetId = 1 },
                new CharacterEntity { Id = 5, Name = "Leia Organa", Height = "150", Weight = "49", HairColor = "brown", SkinColor = "light", EyeColor = "brown", BirthYear = "19BBY", Gender = "female", PlanetId = 2 },
                new CharacterEntity { Id = 6, Name = "Owen Lars", Height = "178", Weight = "120", HairColor = "brown, grey", SkinColor = "light", EyeColor = "blue", BirthYear = "52BBY", Gender = "male", PlanetId = 1 },
                new CharacterEntity { Id = 7, Name = "Beru Whitesun lars", Height = "165", Weight = "75", HairColor = "brown", SkinColor = "light", EyeColor = "blue", BirthYear = "47BBY", Gender = "female", PlanetId = 1 },
                new CharacterEntity { Id = 8, Name = "R5-D4", Height = "97", Weight = "32", HairColor = "n/a", SkinColor = "white, red", EyeColor = "red", BirthYear = "unknown", Gender = "n/a", PlanetId = 1},
                new CharacterEntity { Id = 9, Name = "Biggs Darklighter", Height = "183", Weight = "84", HairColor = "black", SkinColor = "light", EyeColor = "brown", BirthYear = "24BBY", Gender = "male", PlanetId = 1 }
            );

            // vehicles
            modelBuilder.Entity<VehicleEntity>().HasData(
                new VehicleEntity { Id = 1, Name = "Sand Crawler", Model = "Digger Crawler", Manufacturer = "Corellia Mining Corporation", CostInCredits = "150000", Length = "36.8 ", MaxAtmospheringSpeed = "30", Crew = "46", Passengers = "30", CargoCapacity = "50000", Consumables = "2 months", VehicleClass = "wheeled" },
                new VehicleEntity { Id = 2, Name = "T-16 skyhopper", Model = "T-16 skyhopper", Manufacturer = "Incom Corporation", CostInCredits = "14500", Length = "10.4 ", MaxAtmospheringSpeed = "1200", Crew = "1", Passengers = "1", CargoCapacity = "50", Consumables = "0", VehicleClass = "repulsorcraft" },
                new VehicleEntity { Id = 3, Name = "X-34 landspeeder", Model = "X-34 landspeeder", Manufacturer = "SoroSuub Corporation", CostInCredits = "10550", Length = "3.4 ", MaxAtmospheringSpeed = "250", Crew = "1", Passengers = "1", CargoCapacity = "5", Consumables = "unknown", VehicleClass = "repulsorcraft" },
                new VehicleEntity { Id = 4, Name = "TIE/LN starfighter", Model = "Twin Ion Engine/Ln Starfighter", Manufacturer = "Sienar Fleet Systems", CostInCredits = "unknown", Length = "36.4", MaxAtmospheringSpeed = "1200", Crew = "1", Passengers = "0", CargoCapacity = "65", Consumables = "2 days", VehicleClass = "starfighter" },
                new VehicleEntity { Id = 5, Name = "Snowspeeder", Model = "t-47 airspeeder", Manufacturer = "Incom corporation", CostInCredits = "unknown", Length = "4.5", MaxAtmospheringSpeed = "650", Crew = "2", Passengers = "0", CargoCapacity = "10", Consumables = "none", VehicleClass = "airspeeder" },
                new VehicleEntity { Id = 6, Name = "TIE bomber", Model = "TIE/sa bomber", Manufacturer = "Sienar Fleet Systems", CostInCredits = "unknown", Length = "7.8", MaxAtmospheringSpeed = "850", Crew = "1", Passengers = "0", CargoCapacity = "none", Consumables = "2 days", VehicleClass = "space/planetary bomber" },
                new VehicleEntity { Id = 7, Name = "AT-AT", Model = "All Terrain Armored Transport", Manufacturer = "Kuat Drive Yards, Imperial Department of Military Research", CostInCredits = "unknown", Length = "20", MaxAtmospheringSpeed = "60", Crew = "5", Passengers = "40", CargoCapacity = "1000", Consumables = "unknown", VehicleClass = "assault walker" },
                new VehicleEntity { Id = 8, Name = "AT-ST", Model = "All Terrain Scout Transport", Manufacturer = "Kuat Drive Yards, Imperial Department of Military Research", CostInCredits = "unknown", Length = "2 ", MaxAtmospheringSpeed = "90", Crew = "2", Passengers = "0", CargoCapacity = "200", Consumables = "none", VehicleClass = "walker" },
                new VehicleEntity { Id = 9, Name = "Storm IV Twin-Pod cloud car", Model = "Storm IV Twin-Pod", Manufacturer = "Bespin Motors", CostInCredits = "75000", Length = "7", MaxAtmospheringSpeed = "1500", Crew = "2", Passengers = "0", CargoCapacity = "10", Consumables = "1 day", VehicleClass = "repulsorcraft" },
                new VehicleEntity { Id = 10, Name = "Sail barge", Model = "Modified Luxury Sail Barge", Manufacturer = "Ubrikkian Industries Custom Vehicle Division", CostInCredits = "285000", Length = "30", MaxAtmospheringSpeed = "100", Crew = "26", Passengers = "500", CargoCapacity = "2000000", Consumables = "Live food tanks", VehicleClass = "sail barge" }
            );

            // starship
            modelBuilder.Entity<StarshipEntity>().HasData(
                new StarshipEntity { Id = 1, Name = "CR90 corvette", Model = "CR90 corvette", Manufacturer = "Corellian Engineering Corporation", CostInCredits = "3500000", Length = "150", MaxAtmospheringSpeed = "950", Crew = "30-165", Passengers = "600", CargoCapacity = "3000000", Consumables = "1 year", HyperdriveRating = "2.0", MGLT = "60", StarshipClass = "corvette" },
                new StarshipEntity { Id = 2, Name = "Star Destroyer", Model = "Imperial I-class Star Destroyer", Manufacturer = "Kuat Drive Yards", CostInCredits = "150000000", Length = "1,600", MaxAtmospheringSpeed = "975", Crew = "47,060", Passengers = "n/a", CargoCapacity = "36000000", Consumables = "2 years", HyperdriveRating = "2.0", MGLT = "60", StarshipClass = "Star Destroyer" }, 
                new StarshipEntity { Id = 3, Name = "Sentinel-class landing craft", Model = "Sentinel-class landing craft", Manufacturer = "Sienar Fleet Systems, Cyngus Spaceworks", CostInCredits = "240000", Length = "38", MaxAtmospheringSpeed = "1000", Crew = "5", Passengers = "75", CargoCapacity = "180000", Consumables = "1 month", HyperdriveRating = "1.0", MGLT = "70", StarshipClass = "landing craft" },
                new StarshipEntity { Id = 4, Name = "Death Star", Model = "DS-1 Orbital Battle Station", Manufacturer = "Imperial Department of Military Research, Sienar Fleet Systems", CostInCredits = "1000000000000", Length = "120000", MaxAtmospheringSpeed = "n/a", Crew = "342,953", Passengers = "843,342", CargoCapacity = "1000000000000", Consumables = "3 years", HyperdriveRating = "4.0", MGLT = "10", StarshipClass = "Deep Space Mobile Battlestation" },
                new StarshipEntity { Id = 5, Name = "Millennium Falcon", Model = "YT-1300 light freighter", Manufacturer = "Corellian Engineering Corporation", CostInCredits = "100000", Length = "34.37", MaxAtmospheringSpeed = "1050", Crew = "4", Passengers = "6", CargoCapacity = "100000", Consumables = "2 months", HyperdriveRating = "0.5", MGLT = "75", StarshipClass = "Light freighter" },
                new StarshipEntity { Id = 6, Name = "Y-wing", Model = "BTL Y-wing", Manufacturer = "Koensayr Manufacturing", CostInCredits = "134999", Length = "14", MaxAtmospheringSpeed = "1000km", Crew = "2", Passengers = "0", CargoCapacity = "110", Consumables = "1 week", HyperdriveRating = "1.0", MGLT = "80", StarshipClass = "assault starfighter" },
                new StarshipEntity { Id = 7, Name = "X-wing", Model = "T-65 X-wing", Manufacturer = "Incom Corporation", CostInCredits = "149999", Length = "12.5", MaxAtmospheringSpeed = "1050", Crew = "1", Passengers = "0", CargoCapacity = "110", Consumables = "1 week", HyperdriveRating = "1.0", MGLT = "100", StarshipClass = "Starfighter" },
                new StarshipEntity { Id = 8, Name = "TIE Advanced x1", Model = "Twin Ion Engine Advanced x1", Manufacturer = "Sienar Fleet Systems", CostInCredits = "unknown", Length = "9.2", MaxAtmospheringSpeed = "1200", Crew = "1", Passengers = "0", CargoCapacity = "150", Consumables = "5 days", HyperdriveRating = "1.0", MGLT = "105", StarshipClass = "Starfighter" },
                new StarshipEntity { Id = 9, Name = "Executor", Model = "Executor-class star dreadnought", Manufacturer = "Kuat Drive Yards, Fondor Shipyards", CostInCredits = "1143350000", Length = "19000", MaxAtmospheringSpeed = "n/a", Crew = "279,144", Passengers = "38000", CargoCapacity = "250000000", Consumables = "6 years", HyperdriveRating = "2.0", MGLT = "40", StarshipClass = "Star dreadnought" },
                new StarshipEntity { Id = 10, Name = "Rebel transport", Model = "GR-75 medium transport", Manufacturer = "Gallofree Yards, Inc.", CostInCredits = "unknown", Length = "90", MaxAtmospheringSpeed = "650", Crew = "6", Passengers = "90", CargoCapacity = "19000000", Consumables = "6 months", HyperdriveRating = "4.0", MGLT = "20", StarshipClass = "Medium transport" }
            );
        }
    }
}