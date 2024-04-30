using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace may.the.fourth.backend.data.migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Filmes",
                columns: table => new
                {
                    FilmeID = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Titulo = table.Column<string>(type: "VARCHAR(500)", nullable: false),
                    Episodio = table.Column<int>(type: "INT", nullable: true),
                    TextoAbertura = table.Column<string>(type: "VARCHAR(500)", nullable: true),
                    Diretor = table.Column<string>(type: "VARCHAR(150)", nullable: true),
                    Produtor = table.Column<string>(type: "VARCHAR(150)", nullable: true),
                    DataLancamento = table.Column<DateTime>(type: "DATE", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filmes", x => x.FilmeID);
                });

            migrationBuilder.CreateTable(
                name: "Planets",
                columns: table => new
                {
                    PlanetID = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "VARCHAR(150)", nullable: false),
                    RotationPeriod = table.Column<string>(type: "VARCHAR(10)", nullable: false),
                    OrbitalPeriod = table.Column<string>(type: "VARCHAR(10)", nullable: false),
                    Diameter = table.Column<string>(type: "VARCHAR(15)", nullable: false),
                    Climate = table.Column<string>(type: "VARCHAR(150)", nullable: false),
                    Gravity = table.Column<string>(type: "VARCHAR(150)", nullable: false),
                    Terrain = table.Column<string>(type: "VARCHAR(150)", nullable: false),
                    SurfaceWater = table.Column<string>(type: "VARCHAR(10)", nullable: false),
                    Population = table.Column<string>(type: "VARCHAR(15)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Planets", x => x.PlanetID);
                });

            migrationBuilder.CreateTable(
                name: "Starship",
                columns: table => new
                {
                    StarshipID = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "VARCHAR(150)", nullable: false),
                    Model = table.Column<string>(type: "VARCHAR(150)", nullable: false),
                    Manufacturer = table.Column<string>(type: "VARCHAR(150)", nullable: false),
                    CostInCredits = table.Column<string>(type: "VARCHAR(20)", nullable: false),
                    Length = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    MaxAtmospheringSpeed = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    Crew = table.Column<string>(type: "VARCHAR(20)", nullable: false),
                    Passengers = table.Column<string>(type: "VARCHAR(20)", nullable: false),
                    CargoCapacity = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    Consumables = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    HyperdriveRating = table.Column<string>(type: "VARCHAR(20)", nullable: false),
                    MGLT = table.Column<string>(type: "VARCHAR(20)", nullable: false),
                    StarshipClass = table.Column<string>(type: "VARCHAR(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Starship", x => x.StarshipID);
                });

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    VehiclesID = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "VARCHAR(150)", nullable: false),
                    Model = table.Column<string>(type: "VARCHAR(150)", nullable: false),
                    Manufacturer = table.Column<string>(type: "VARCHAR(150)", nullable: false),
                    CostInCredits = table.Column<string>(type: "VARCHAR(10)", nullable: false),
                    Length = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    MaxAtmospheringSpeed = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    Crew = table.Column<string>(type: "VARCHAR(10)", nullable: false),
                    Passengers = table.Column<string>(type: "VARCHAR(10)", nullable: false),
                    CargoCapacity = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    Consumables = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    VehicleClass = table.Column<string>(type: "VARCHAR(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.VehiclesID);
                });

            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    CharacterID = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "VARCHAR(150)", nullable: false),
                    Height = table.Column<string>(type: "VARCHAR(10)", nullable: false),
                    Weight = table.Column<string>(type: "VARCHAR(10)", nullable: false),
                    HairColor = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    SkinColor = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    EyeColor = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    BirthYear = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    Gender = table.Column<string>(type: "VARCHAR(20)", nullable: false),
                    PlanetID = table.Column<int>(type: "INT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.CharacterID);
                    table.ForeignKey(
                        name: "FK_Characters_Planets_PlanetID",
                        column: x => x.PlanetID,
                        principalTable: "Planets",
                        principalColumn: "PlanetID");
                });

            migrationBuilder.CreateTable(
                name: "FilmsPlanets",
                columns: table => new
                {
                    PlanetID = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmsPlanets", x => x.PlanetID);
                    table.ForeignKey(
                        name: "FK_FilmsPlanets_Planets_PlanetID",
                        column: x => x.PlanetID,
                        principalTable: "Planets",
                        principalColumn: "PlanetID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Filmes",
                columns: new[] { "FilmeID", "DataLancamento", "Diretor", "Episodio", "Produtor", "TextoAbertura", "Titulo" },
                values: new object[,]
                {
                    { 1, new DateTime(2028, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jana Doe", 10, "Leo Smith", "After the fall of the Empire, the galaxy face", "The Rise of the Jedi" },
                    { 2, null, null, null, null, null, "The Battle of the Stars" },
                    { 3, null, null, null, null, null, "Return of the Light" },
                    { 4, null, null, null, null, null, "Warriors of the Shadow Realm" },
                    { 5, null, null, null, null, null, "The Galactic Quest" },
                    { 6, null, null, null, null, null, "Rise of the Planetara" },
                    { 7, null, null, null, null, null, "Echoes of the Stars" },
                    { 8, null, null, null, null, null, "The Return of the Voyager" },
                    { 9, null, null, null, null, null, "Voyager's Endgame" },
                    { 10, null, null, null, null, null, "Galactic Odyssey" },
                    { 11, null, null, null, null, null, "The Edge of the Universe" }
                });

            migrationBuilder.InsertData(
                table: "Planets",
                columns: new[] { "PlanetID", "Climate", "Diameter", "Gravity", "Name", "OrbitalPeriod", "Population", "RotationPeriod", "SurfaceWater", "Terrain" },
                values: new object[,]
                {
                    { 1, "arid", "10465", "1 standard", "Tatooine", "304", "200000", "23", "1", "desert" },
                    { 2, "temperate", "12500", "1 standard", "Alderaan", "364", "2000000000", "24", "40", "grasslands, mountains" },
                    { 3, "temperate, tropical", "10200", "1 standard", "Yavin IV", "4818", "1000", "24", "8", "jungle, rainforests" },
                    { 4, "frozen", "7200", "1.1 standard", "Hoth", "549", "unknown", "23", "100", "tundra, ice caves, mountain ranges" },
                    { 5, "murky", "8900", "N/A", "Dagobah", "341", "unknown", "23", "8", "swamp, jungles" },
                    { 6, "temperate", "118000", "1.5 (surface), 1 standard (Cloud City)", "Bespin", "5110", "6000000", "12", "0", "gas giant" },
                    { 7, "temperate", "4900", "0.85 standard", "Endor", "402", "30000000", "18", "8", "forests, mountains, lakes" },
                    { 8, "temperate", "12120", "1 standard", "Naboo", "312", "4500000000", "26", "12", "grassy hills, swamps, forests, mountains" },
                    { 9, "temperate", "12240", "1 standard", "Coruscant", "368", "1000000000000", "24", "unknown", "cityscape, mountains" },
                    { 10, "temperate", "19720", "1 standard", "Kamino", "463", "1000000000", "27", "100", "ocean" }
                });

            migrationBuilder.InsertData(
                table: "Starship",
                columns: new[] { "StarshipID", "CargoCapacity", "Consumables", "CostInCredits", "Crew", "HyperdriveRating", "Length", "MGLT", "Manufacturer", "MaxAtmospheringSpeed", "Model", "Name", "Passengers", "StarshipClass" },
                values: new object[,]
                {
                    { 1, "3000000", "1 year", "3500000", "30-165", "2.0", "150", "60", "Corellian Engineering Corporation", "950", "CR90 corvette", "CR90 corvette", "600", "corvette" },
                    { 2, "36000000", "2 years", "150000000", "47,060", "2.0", "1,600", "60", "Kuat Drive Yards", "975", "Imperial I-class Star Destroyer", "Star Destroyer", "n/a", "Star Destroyer" },
                    { 3, "180000", "1 month", "240000", "5", "1.0", "38", "70", "Sienar Fleet Systems, Cyngus Spaceworks", "1000", "Sentinel-class landing craft", "Sentinel-class landing craft", "75", "landing craft" },
                    { 4, "1000000000000", "3 years", "1000000000000", "342,953", "4.0", "120000", "10", "Imperial Department of Military Research, Sienar Fleet Systems", "n/a", "DS-1 Orbital Battle Station", "Death Star", "843,342", "Deep Space Mobile Battlestation" },
                    { 5, "100000", "2 months", "100000", "4", "0.5", "34.37", "75", "Corellian Engineering Corporation", "1050", "YT-1300 light freighter", "Millennium Falcon", "6", "Light freighter" },
                    { 6, "110", "1 week", "134999", "2", "1.0", "14", "80", "Koensayr Manufacturing", "1000km", "BTL Y-wing", "Y-wing", "0", "assault starfighter" },
                    { 7, "110", "1 week", "149999", "1", "1.0", "12.5", "100", "Incom Corporation", "1050", "T-65 X-wing", "X-wing", "0", "Starfighter" },
                    { 8, "150", "5 days", "unknown", "1", "1.0", "9.2", "105", "Sienar Fleet Systems", "1200", "Twin Ion Engine Advanced x1", "TIE Advanced x1", "0", "Starfighter" },
                    { 9, "250000000", "6 years", "1143350000", "279,144", "2.0", "19000", "40", "Kuat Drive Yards, Fondor Shipyards", "n/a", "Executor-class star dreadnought", "Executor", "38000", "Star dreadnought" },
                    { 10, "19000000", "6 months", "unknown", "6", "4.0", "90", "20", "Gallofree Yards, Inc.", "650", "GR-75 medium transport", "Rebel transport", "90", "Medium transport" }
                });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "VehiclesID", "CargoCapacity", "Consumables", "CostInCredits", "Crew", "Length", "Manufacturer", "MaxAtmospheringSpeed", "Model", "Name", "Passengers", "VehicleClass" },
                values: new object[,]
                {
                    { 1, "50000", "2 months", "150000", "46", "36.8 ", "Corellia Mining Corporation", "30", "Digger Crawler", "Sand Crawler", "30", "wheeled" },
                    { 2, "50", "0", "14500", "1", "10.4 ", "Incom Corporation", "1200", "T-16 skyhopper", "T-16 skyhopper", "1", "repulsorcraft" },
                    { 3, "5", "unknown", "10550", "1", "3.4 ", "SoroSuub Corporation", "250", "X-34 landspeeder", "X-34 landspeeder", "1", "repulsorcraft" },
                    { 4, "65", "2 days", "unknown", "1", "36.4", "Sienar Fleet Systems", "1200", "Twin Ion Engine/Ln Starfighter", "TIE/LN starfighter", "0", "starfighter" },
                    { 5, "10", "none", "unknown", "2", "4.5", "Incom corporation", "650", "t-47 airspeeder", "Snowspeeder", "0", "airspeeder" },
                    { 6, "none", "2 days", "unknown", "1", "7.8", "Sienar Fleet Systems", "850", "TIE/sa bomber", "TIE bomber", "0", "space/planetary bomber" },
                    { 7, "1000", "unknown", "unknown", "5", "20", "Kuat Drive Yards, Imperial Department of Military Research", "60", "All Terrain Armored Transport", "AT-AT", "40", "assault walker" },
                    { 8, "200", "none", "unknown", "2", "2 ", "Kuat Drive Yards, Imperial Department of Military Research", "90", "All Terrain Scout Transport", "AT-ST", "0", "walker" },
                    { 9, "10", "1 day", "75000", "2", "7", "Bespin Motors", "1500", "Storm IV Twin-Pod", "Storm IV Twin-Pod cloud car", "0", "repulsorcraft" },
                    { 10, "2000000", "Live food tanks", "285000", "26", "30", "Ubrikkian Industries Custom Vehicle Division", "100", "Modified Luxury Sail Barge", "Sail barge", "500", "sail barge" }
                });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "CharacterID", "BirthYear", "EyeColor", "Gender", "HairColor", "Height", "Name", "PlanetID", "SkinColor", "Weight" },
                values: new object[,]
                {
                    { 1, "19BBY", "blue", "male", "blond", "172", "Luke Skywalker", 1, "fair", "77" },
                    { 2, "112BBY", "yellow", "n/a", "n/a", "167", "C-3PO", 1, "gold", "75" },
                    { 3, "33BBY", "red", "n/a", "n/a", "96", "R2-D2", 8, "white, blue", "32" },
                    { 4, "41.9BBY", "yellow", "male", "none", "202", "Darth Vader", 1, "white", "136" },
                    { 5, "19BBY", "brown", "female", "brown", "150", "Leia Organa", 2, "light", "49" },
                    { 6, "52BBY", "blue", "male", "brown, grey", "178", "Owen Lars", 1, "light", "120" },
                    { 7, "47BBY", "blue", "female", "brown", "165", "Beru Whitesun lars", 1, "light", "75" },
                    { 8, "unknown", "red", "n/a", "n/a", "97", "R5-D4", 1, "white, red", "32" },
                    { 9, "24BBY", "brown", "male", "black", "183", "Biggs Darklighter", 1, "light", "84" }
                });

            migrationBuilder.InsertData(
                table: "FilmsPlanets",
                column: "PlanetID",
                values: new object[]
                {
                    1,
                    2,
                    3,
                    4,
                    5,
                    6,
                    7,
                    8,
                    9,
                    10
                });

            migrationBuilder.CreateIndex(
                name: "IX_Characters_PlanetID",
                table: "Characters",
                column: "PlanetID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Characters");

            migrationBuilder.DropTable(
                name: "Filmes");

            migrationBuilder.DropTable(
                name: "FilmsPlanets");

            migrationBuilder.DropTable(
                name: "Starship");

            migrationBuilder.DropTable(
                name: "Vehicles");

            migrationBuilder.DropTable(
                name: "Planets");
        }
    }
}
