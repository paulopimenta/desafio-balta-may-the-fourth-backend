using Microsoft.EntityFrameworkCore;

using May.The.Fourth.Backend.Data.Entities;

namespace May.The.Fourth.Backend.Data.Contexts
{
    public class StarWarsContext : DbContext
    {        
        public StarWarsContext(DbContextOptions<StarWarsContext> options)
            : base(options) { }

        public DbSet<FilmEntity> Films { get; set; }
        public DbSet<PlanetEntity> Planets { get; set; }
        public DbSet<FilmPlanetEntity> FilmsPlanets { get; set; }
        public DbSet<CharacterEntity> Characters { get; set; }
        public DbSet<VehicleEntity> Vehicles { get; set; }
        public DbSet<FilmCharacterEntity> FilmsCharacters { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // films
            var films = new FilmEntity[]
            {
                new FilmEntity { Id = 1, Title = "The Rise of the Jedi", Episode = 10, OpeningCrawl = "After the fall of the Empire, the galaxy face", Director = "Jana Doe", Producer = "Leo Smith", ReleaseDate = new DateTime(2028, 12, 15) },
                new FilmEntity { Id = 2, Title = "The Battle of the Stars" },
                new FilmEntity { Id = 3, Title = "Return of the Light" },
                new FilmEntity { Id = 4, Title = "Warriors of the Shadow Realm" },
                new FilmEntity { Id = 5, Title = "The Galactic Quest" },
                new FilmEntity { Id = 6, Title = "Rise of the Planetara" },
                new FilmEntity { Id = 7, Title = "Echoes of the Stars" },
                new FilmEntity { Id = 8, Title = "The Return of the Voyager" },
                new FilmEntity { Id = 9, Title = "Voyager's Endgame" },
                new FilmEntity { Id = 10, Title = "Galactic Odyssey" },
                new FilmEntity { Id = 11, Title = "The Edge of the Universe" }
            };
            modelBuilder.Entity<FilmEntity>().HasData(films);

            // films-characters
            var filmsCharacters = new FilmCharacterEntity[]
            {
                new FilmCharacterEntity { FilmId = 1, CharacterId = 1 }, //mas ver q isto era para o filme "A New Hope" script do Diogo
                new FilmCharacterEntity { FilmId = 1, CharacterId = 2 },
                new FilmCharacterEntity { FilmId = 1, CharacterId = 3 },
                new FilmCharacterEntity { FilmId = 1, CharacterId = 4 },
                new FilmCharacterEntity { FilmId = 1, CharacterId = 5 },
                new FilmCharacterEntity { FilmId = 1, CharacterId = 6 },
                new FilmCharacterEntity { FilmId = 1, CharacterId = 7 },
                new FilmCharacterEntity { FilmId = 1, CharacterId = 8 },
                new FilmCharacterEntity { FilmId = 1, CharacterId = 9 }
            };
            modelBuilder.Entity<FilmCharacterEntity>().HasData(filmsCharacters);

            // films-vehicle
            
            // films-starships

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
                new VehicleEntity { Id = 1, Name = "Sand Crawler", Model = "Digger Crawler", Manufacturer = "Corellia Mining Corporation", CostInCredits = "150000", Length = "36.8 ", MaxAtmospheringSpeed = "30", Crew = "46", Passengers = "30", CargoCapacity = "50000", Consumables = "2 months", Vehicle_Class = "wheeled" },
                new VehicleEntity { Id = 2, Name = "T-16 skyhopper", Model = "T-16 skyhopper", Manufacturer = "Incom Corporation", CostInCredits = "14500", Length = "10.4 ", MaxAtmospheringSpeed = "1200", Crew = "1", Passengers = "1", CargoCapacity = "50", Consumables = "0", Vehicle_Class = "repulsorcraft" },
                new VehicleEntity { Id = 3, Name = "X-34 landspeeder", Model = "X-34 landspeeder", Manufacturer = "SoroSuub Corporation", CostInCredits = "10550", Length = "3.4 ", MaxAtmospheringSpeed = "250", Crew = "1", Passengers = "1", CargoCapacity = "5", Consumables = "unknown", Vehicle_Class = "repulsorcraft" },
                new VehicleEntity { Id = 4, Name = "TIE/LN starfighter", Model = "Twin Ion Engine/Ln Starfighter", Manufacturer = "Sienar Fleet Systems", CostInCredits = "unknown", Length = "36.4", MaxAtmospheringSpeed = "1200", Crew = "1", Passengers = "0", CargoCapacity = "65", Consumables = "2 days", Vehicle_Class = "starfighter" },
                new VehicleEntity { Id = 5, Name = "Snowspeeder", Model = "t-47 airspeeder", Manufacturer = "Incom corporation", CostInCredits = "unknown", Length = "4.5", MaxAtmospheringSpeed = "650", Crew = "2", Passengers = "0", CargoCapacity = "10", Consumables = "none", Vehicle_Class = "airspeeder" },
                new VehicleEntity { Id = 6, Name = "TIE bomber", Model = "TIE/sa bomber", Manufacturer = "Sienar Fleet Systems", CostInCredits = "unknown", Length = "7.8", MaxAtmospheringSpeed = "850", Crew = "1", Passengers = "0", CargoCapacity = "none", Consumables = "2 days", Vehicle_Class = "space/planetary bomber" },
                new VehicleEntity { Id = 7, Name = "AT-AT", Model = "All Terrain Armored Transport", Manufacturer = "Kuat Drive Yards, Imperial Department of Military Research", CostInCredits = "unknown", Length = "20", MaxAtmospheringSpeed = "60", Crew = "5", Passengers = "40", CargoCapacity = "1000", Consumables = "unknown", Vehicle_Class = "assault walker" },
                new VehicleEntity { Id = 8, Name = "AT-ST", Model = "All Terrain Scout Transport", Manufacturer = "Kuat Drive Yards, Imperial Department of Military Research", CostInCredits = "unknown", Length = "2 ", MaxAtmospheringSpeed = "90", Crew = "2", Passengers = "0", CargoCapacity = "200", Consumables = "none", Vehicle_Class = "walker" },
                new VehicleEntity { Id = 9, Name = "Storm IV Twin-Pod cloud car", Model = "Storm IV Twin-Pod", Manufacturer = "Bespin Motors", CostInCredits = "75000", Length = "7", MaxAtmospheringSpeed = "1500", Crew = "2", Passengers = "0", CargoCapacity = "10", Consumables = "1 day", Vehicle_Class = "repulsorcraft" },
                new VehicleEntity { Id = 10, Name = "Sail barge", Model = "Modified Luxury Sail Barge", Manufacturer = "Ubrikkian Industries Custom Vehicle Division", CostInCredits = "285000", Length = "30", MaxAtmospheringSpeed = "100", Crew = "26", Passengers = "500", CargoCapacity = "2000000", Consumables = "Live food tanks", Vehicle_Class = "sail barge" }
            );
        }
    }
}