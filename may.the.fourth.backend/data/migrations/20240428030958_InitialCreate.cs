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
                name: "Vehicles",
                columns: table => new
                {
                    VehicleID = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "VARCHAR(255)", nullable: false),
                    Model = table.Column<string>(type: "VARCHAR(255)", nullable: false),
                    Manufacturer = table.Column<string>(type: "VARCHAR(255)", nullable: false),
                    CostInCredits = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    Length = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    MaxSpeed = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    Crew = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    Passengers = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    CargoCapacity = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    Consumables = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    Class = table.Column<string>(type: "VARCHAR(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.VehicleID);
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
                table: "Vehicles",
                columns: new[] { "VehicleID", "CargoCapacity", "Class", "Consumables", "CostInCredits", "Crew", "Length", "Manufacturer", "MaxSpeed", "Model", "Name", "Passengers" },
                values: new object[,]
                {
                    { 4, "50000", "wheeled", "2 months", "150000", "46", "36.8", "Corellia Mining Corporation", "30", "Digger Crawler", "Sand Crawler", "30" },
                    { 6, "50", "repulsorcraft", "0", "14500", "1", "10.4", "Incom Corporation", "1200", "T-16 skyhopper", "T-16 skyhopper", "1" },
                    { 7, "5", "repulsorcraft", "unknown", "10550", "1", "3.4", "SoroSuub Corporation", "250", "X-34 landspeeder", "X-34 landspeeder", "1" },
                    { 8, "65", "starfighter", "2 days", "unknown", "1", "6.4", "Sienar Fleet Systems", "1200", "Twin Ion Engine/Ln Starfighter", "TIE/LN starfighter", "0" },
                    { 14, "10", "airspeeder", "none", "unknown", "2", "4.5", "Incom corporation", "650", "t-47 airspeeder", "Snowspeeder", "0" },
                    { 16, "none", "space/planetary bomber", "2 days", "unknown", "1", "7.8", "Sienar Fleet Systems", "850", "TIE/sa bomber", "TIE bomber", "0" },
                    { 18, "1000", "assault walker", "unknown", "unknown", "5", "20", "Kuat Drive Yards, Imperial Department of Military Research", "60", "All Terrain Armored Transport", "AT-AT", "40" },
                    { 19, "200", "walker", "none", "unknown", "2", "2", "Kuat Drive Yards, Imperial Department of Military Research", "90", "All Terrain Scout Transport", "AT-ST", "0" },
                    { 20, "10", "repulsorcraft", "1 day", "75000", "2", "7", "Bespin Motors", "1500", "Storm IV Twin-Pod", "Storm IV Twin-Pod cloud car", "0" },
                    { 24, "2000000", "sail barge", "Live food tanks", "285000", "26", "30", "Ubrikkian Industries Custom Vehicle Division", "100", "Modified Luxury Sail Barge", "Sail barge", "500" }
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Filmes");

            migrationBuilder.DropTable(
                name: "FilmsPlanets");

            migrationBuilder.DropTable(
                name: "Vehicles");

            migrationBuilder.DropTable(
                name: "Planets");
        }
    }
}
