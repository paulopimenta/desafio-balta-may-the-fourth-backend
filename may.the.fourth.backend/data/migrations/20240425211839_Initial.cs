using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace may.the.fourth.backend.data.migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "VARCHAR(500)", nullable: false),
                    Episode = table.Column<int>(type: "INT", nullable: true),
                    OpeningCrawl = table.Column<string>(type: "TEXT", nullable: true),
                    Director = table.Column<string>(type: "VARCHAR(150)", nullable: true),
                    Producer = table.Column<string>(type: "VARCHAR(150)", nullable: true),
                    ReleaseDate = table.Column<DateTime>(type: "DATE", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Starships",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "VARCHAR(255)", nullable: false),
                    Model = table.Column<string>(type: "VARCHAR(255)", nullable: true),
                    Manufacturer = table.Column<string>(type: "VARCHAR(255)", nullable: true),
                    CostInCredits = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    Length = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    MaxSpeed = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    Crew = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    Passengers = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    CargoCapacity = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    HyperdriveRating = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    Mglt = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    Consumables = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    Class = table.Column<string>(type: "VARCHAR(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Starships", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Episode", "OpeningCrawl", "Producer", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { 1, "George Lucas", 4, "It is a period of civil war.\\r\\nRebel spaceships, striking\\r\\nfrom a hidden base, have won\\r\\ntheir first victory against\\r\\nthe evil Galactic Empire.\\r\\n\\r\\nDuring the battle, Rebel\\r\\nspies managed to steal secret\\r\\nplans to the Empire''s\\r\\nultimate weapon, the DEATH\\r\\nSTAR, an armored space\\r\\nstation with enough power\\r\\nto destroy an entire planet.\\r\\n\\r\\nPursued by the Empire''s\\r\\nsinister agents, Princess\\r\\nLeia races home aboard her\\r\\nstarship, custodian of the\\r\\nstolen plans that can save her\\r\\npeople and restore\\r\\nfreedom to the galaxy....", "Gary Kurtz, Rick McCallum", new DateTime(1977, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "A New Hope" },
                    { 2, "Irvin Kershner", 5, "It is a dark time for the\\r\\nRebellion. Although the Death\\r\\nStar has been destroyed,\\r\\nImperial troops have driven the\\r\\nRebel forces from their hidden\\r\\nbase and pursued them across\\r\\nthe galaxy.\\r\\n\\r\\nEvading the dreaded Imperial\\r\\nStarfleet, a group of freedom\\r\\nfighters led by Luke Skywalker\\r\\nhas established a new secret\\r\\nbase on the remote ice world\\r\\nof Hoth.\\r\\n\\r\\nThe evil lord Darth Vader,\\r\\nobsessed with finding young\\r\\nSkywalker, has dispatched\\r\\nthousands of remote probes into\\r\\nthe far reaches of space....", "Gary Kurtz, Rick McCallum", new DateTime(1980, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Empire Strikes Back" },
                    { 3, "Richard Marquand", 6, "Luke Skywalker has returned to\\\\r\\\\nhis home planet of Tatooine in\\\\r\\\\nan attempt to rescue his\\\\r\\\\nfriend Han Solo from the\\\\r\\\\nclutches of the vile gangster\\\\r\\\\nJabba the Hutt.\\\\r\\\\n\\\\r\\\\nLittle does Luke know that the\\\\r\\\\nGALACTIC EMPIRE has secretly\\\\r\\\\nbegun construction on a new\\\\r\\\\narmored space station even\\\\r\\\\nmore powerful than the first\\\\r\\\\ndreaded Death Star.\\\\r\\\\n\\\\r\\\\nWhen completed, this ultimate\\\\r\\\\nweapon will spell certain doom\\\\r\\\\nfor the small band of rebels\\\\r\\\\nstruggling to restore freedom\\\\r\\\\nto the galaxy...", "Howard G. Kazanjian, George Lucas, Rick McCallum", new DateTime(1983, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Return of the Jedi" },
                    { 4, "George Lucas", 1, "Turmoil has engulfed the\\r\\nGalactic Republic. The taxation\\r\\nof trade routes to outlying star\\r\\nsystems is in dispute.\\r\\n\\r\\nHoping to resolve the matter\\r\\nwith a blockade of deadly\\r\\nbattleships, the greedy Trade\\r\\nFederation has stopped all\\r\\nshipping to the small planet\\r\\nof Naboo.\\r\\n\\r\\nWhile the Congress of the\\r\\nRepublic endlessly debates\\r\\nthis alarming chain of events,\\r\\nthe Supreme Chancellor has\\r\\nsecretly dispatched two Jedi\\r\\nKnights, the guardians of\\r\\npeace and justice in the\\r\\ngalaxy, to settle the conflict....", "Rick McCallum", new DateTime(1999, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Phantom Menace" },
                    { 5, "George Lucas", 2, "There is unrest in the Galactic\\r\\nSenate. Several thousand solar\\r\\nsystems have declared their\\r\\nintentions to leave the Republic.\\r\\n\\r\\nThis separatist movement,\\r\\nunder the leadership of the\\r\\nmysterious Count Dooku, has\\r\\nmade it difficult for the limited\\r\\nnumber of Jedi Knights to maintain \\r\\npeace and order in the galaxy.\\r\\n\\r\\nSenator Amidala, the former\\r\\nQueen of Naboo, is returning\\r\\nto the Galactic Senate to vote\\r\\non the critical issue of creating\\r\\nan ARMY OF THE REPUBLIC\\r\\nto assist the overwhelmed\\r\\nJedi....", "Rick McCallum", new DateTime(2002, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Attack of the Clones" },
                    { 6, "George Lucas", 3, "War! The Republic is crumbling\\r\\nunder attacks by the ruthless\\r\\nSith Lord, Count Dooku.\\r\\nThere are heroes on both sides.\\r\\nEvil is everywhere.\\r\\n\\r\\nIn a stunning move, the\\r\\nfiendish droid leader, General\\r\\nGrievous, has swept into the\\r\\nRepublic capital and kidnapped\\r\\nChancellor Palpatine, leader of\\r\\nthe Galactic Senate.\\r\\n\\r\\nAs the Separatist Droid Army\\r\\nattempts to flee the besieged\\r\\ncapital with their valuable\\r\\nhostage, two Jedi Knights lead a\\r\\ndesperate mission to rescue the\\r\\ncaptive Chancellor....", "Rick McCallum", new DateTime(2005, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Revenge of the Sith" }
                });

            migrationBuilder.InsertData(
                table: "Starships",
                columns: new[] { "Id", "CargoCapacity", "Class", "Consumables", "CostInCredits", "Crew", "HyperdriveRating", "Length", "Manufacturer", "MaxSpeed", "Mglt", "Model", "Name", "Passengers" },
                values: new object[,]
                {
                    { 2, "3000000", "corvette", "1 year", "3500000", "30-165", "2.0", "150", "Corellian Engineering Corporation", "950", "60", "CR90 corvette", "CR90 corvette", "600" },
                    { 3, "36000000", "Star Destroyer", "2 years", "150000000", "47,060", "2.0", "1,600", "Kuat Drive Yards", "975", "60", "Imperial I-class Star Destroyer", "Star Destroyer", "n/a" },
                    { 5, "180000", "landing craft", "1 month", "240000", "5", "1.0", "38", "Sienar Fleet Systems, Cyngus Spaceworks", "1000", "70", "Sentinel-class landing craft", "Sentinel-class landing craft", "75" },
                    { 9, "1000000000000", "Deep Space Mobile Battlestation", "3 years", "1000000000000", "342,953", "4.0", "120000", "Imperial Department of Military Research, Sienar Fleet Systems", "n/a", "10", "DS-1 Orbital Battle Station", "Death Star", "843,342" },
                    { 10, "100000", "Light freighter", "2 months", "100000", "4", "0.5", "34.37", "Corellian Engineering Corporation", "1050", "75", "YT-1300 light freighter", "Millennium Falcon", "6" },
                    { 11, "110", "assault starfighter", "1 week", "134999", "2", "1.0", "14", "Koensayr Manufacturing", "1000km", "80", "BTL Y-wing", "Y-wing", "0" },
                    { 12, "110", "Starfighter", "1 week", "149999", "1", "1.0", "12.5", "Incom Corporation", "1050", "100", "T-65 X-wing", "X-wing", "0" },
                    { 13, "150", "Starfighter", "5 days", "unknown", "1", "1.0", "9.2", "Sienar Fleet Systems", "1200", "105", "Twin Ion Engine Advanced x1", "TIE Advanced x1", "0" },
                    { 15, "250000000", "Star dreadnought", "6 years", "1143350000", "279,144", "2.0", "19000", "Kuat Drive Yards, Fondor Shipyards", "n/a", "40", "Executor-class star dreadnought", "Executor", "38000" },
                    { 17, "19000000", "Medium transport", "6 months", "unknown", "6", "4.0", "90", "Gallofree Yards, Inc.", "650", "20", "GR-75 medium transport", "Rebel transport", "90" },
                    { 21, "70000", "Patrol craft", "1 month", "unknown", "1", "3.0", "21.5", "Kuat Systems Engineering", "1000", "70", "Firespray-31-class patrol and attack", "Slave 1", "6" },
                    { 22, "80000", "Armed government transport", "2 months", "240000", "6", "1.0", "20", "Sienar Fleet Systems", "850", "50", "Lambda-class T-4a shuttle", "Imperial shuttle", "20" },
                    { 23, "6000000", "Escort ship", "2 years", "8500000", "854", "2.0", "300", "Kuat Drive Yards", "800", "40", "EF76 Nebulon-B escort frigate", "EF76 Nebulon-B escort frigate", "75" },
                    { 27, "unknown", "Star Cruiser", "2 years", "104000000", "5400", "1.0", "1200", "Mon Calamari shipyards", "n/a", "60", "MC80 Liberty type Star Cruiser", "Calamari Cruiser", "1200" },
                    { 28, "40", "Starfighter", "1 week", "175000", "1", "1.0", "9.6", "Alliance Underground Engineering, Incom Corporation", "1300", "120", "RZ-1 A-wing Interceptor", "A-wing", "0" },
                    { 29, "45", "Assault Starfighter", "1 week", "220000", "1", "2.0", "16.9", "Slayn & Korpil", "950", "91", "A/SF-01 B-wing starfighter", "B-wing", "0" },
                    { 31, "unknown", "Space cruiser", "unknown", "unknown", "9", "2.0", "115", "Corellian Engineering Corporation", "900", "unknown", "Consular-class cruiser", "Republic Cruiser", "16" },
                    { 32, "4000000000", "Droid control ship", "500 days", "unknown", "175", "2.0", "3170", "Hoersch-Kessel Drive, Inc.", "n/a", "unknown", "Lucrehulk-class Droid Control Ship", "Droid control ship", "139000" },
                    { 39, "65", "Starfighter", "7 days", "200000", "1", "1.0", "11", "Theed Palace Space Vessel Engineering Corps", "1100", "unknown", "N-1 starfighter", "Naboo fighter", "0" },
                    { 40, "unknown", "yacht", "unknown", "unknown", "8", "1.8", "76", "Theed Palace Space Vessel Engineering Corps, Nubia Star Drives", "920", "unknown", "J-type 327 Nubian royal starship", "Naboo Royal Starship", "unknown" },
                    { 41, "2500000", "Space Transport", "30 days", "55000000", "1", "1.5", "26.5", "Republic Sienar Systems", "1180", "unknown", "Star Courier", "Scimitar", "6" },
                    { 43, "unknown", "Diplomatic barge", "1 year", "2000000", "5", "0.7", "39", "Theed Palace Space Vessel Engineering Corps, Nubia Star Drives", "2000", "unknown", "J-type diplomatic barge", "J-type diplomatic barge", "10" },
                    { 47, "unknown", "freighter", "unknown", "unknown", "unknown", "unknown", "390", "Botajef Shipyards", "unknown", "unknown", "Botajef AA-9 Freighter-Liner", "AA-9 Coruscant freighter", "30000" },
                    { 48, "60", "Starfighter", "7 days", "180000", "1", "1.0", "8", "Kuat Systems Engineering", "1150", "unknown", "Delta-7 Aethersprite-class interceptor", "Jedi starfighter", "0" },
                    { 49, "unknown", "yacht", "unknown", "unknown", "4", "0.9", "47.9", "Theed Palace Space Vessel Engineering Corps", "8000", "unknown", "H-type Nubian yacht", "H-type Nubian yacht", "unknown" },
                    { 52, "11250000", "assault ship", "2 years", "unknown", "700", "0.6", "752", "Rothana Heavy Engineering", "unknown", "unknown", "Acclamator I-class assault ship", "Republic Assault ship", "16000" },
                    { 58, "240", "yacht", "7 days", "35700", "3", "1.5", "15.2", "Huppla Pasa Tisc Shipwrights Collective", "1600", "unknown", "Punworcca 116-class interstellar sloop", "Solar Sailer", "11" },
                    { 59, "50000000", "capital ship", "4 years", "125000000", "600", "1.5", "1088", "Rendili StarDrive, Free Dac Volunteers Engineering corps.", "1050", "unknown", "Providence-class carrier/destroyer", "Trade Federation cruiser", "48247" },
                    { 61, "50000", "transport", "56 days", "1000000", "5", "1.0", "18.5", "Cygnus Spaceworks", "2000", "unknown", "Theta-class T-2c shuttle", "Theta-class T-2c shuttle", "16" },
                    { 63, "20000000", "star destroyer", "2 years", "59000000", "7400", "1.0", "1137", "Kuat Drive Yards, Allanteen Six shipyards", "975", "unknown", "Senator-class Star Destroyer", "Republic attack cruiser", "2000" },
                    { 64, "unknown", "yacht", "unknown", "unknown", "3", "0.5", "29.2", "Theed Palace Space Vessel Engineering Corps/Nubia Star Drives, Incorporated", "1050", "unknown", "J-type star skiff", "Naboo star skiff", "3" },
                    { 65, "60", "starfighter", "2 days", "320000", "1", "1.0", "5.47", "Kuat Systems Engineering", "1500", "unknown", "Eta-2 Actis-class light interceptor", "Jedi Interceptor", "0" },
                    { 66, "110", "starfighter", "5 days", "155000", "3", "1.0", "14.5", "Incom Corporation, Subpro Corporation", "1000", "100", "Aggressive Reconnaissance-170 starfighte", "arc-170", "0" },
                    { 68, "40000000", "cruiser", "2 years", "57000000", "200", "1.0", "825", "Hoersch-Kessel Drive, Inc, Gwori Revolutionary Industries", "unknown", "unknown", "Munificent-class star frigate", "Banking clan frigte", "unknown" },
                    { 74, "140", "starfighter", "7 days", "168000", "1", "6", "6.71", "Feethan Ottraw Scalable Assemblies", "1100", "unknown", "Belbullab-22 starfighter", "Belbullab-22 starfighter", "0" },
                    { 75, "60", "starfighter", "15 hours", "102500", "1", "1.0", "7.9", "Kuat Systems Engineering", "1050", "unknown", "Alpha-3 Nimbus-class V-wing starfighter", "V-wing", "0" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Starships");
        }
    }
}
