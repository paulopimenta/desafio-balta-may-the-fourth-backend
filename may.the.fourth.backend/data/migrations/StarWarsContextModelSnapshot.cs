﻿// <auto-generated />
using System;
using May.The.Fourth.Backend.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace may.the.fourth.backend.data.migrations
{
    [DbContext(typeof(StarWarsContext))]
    partial class StarWarsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("May.The.Fourth.Backend.Data.Entities.CharacterEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT")
                        .HasColumnName("CharacterID");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("BirthYear")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnName("BirthYear");

                    b.Property<string>("EyeColor")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnName("EyeColor");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("VARCHAR(20)")
                        .HasColumnName("Gender");

                    b.Property<string>("HairColor")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnName("HairColor");

                    b.Property<string>("Height")
                        .IsRequired()
                        .HasColumnType("VARCHAR(10)")
                        .HasColumnName("Height");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("VARCHAR(150)")
                        .HasColumnName("Name");

                    b.Property<int?>("PlanetId")
                        .HasColumnType("INT")
                        .HasColumnName("PlanetID");

                    b.Property<string>("SkinColor")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnName("SkinColor");

                    b.Property<string>("Weight")
                        .IsRequired()
                        .HasColumnType("VARCHAR(10)")
                        .HasColumnName("Weight");

                    b.HasKey("Id");

                    b.HasIndex("PlanetId");

                    b.ToTable("Characters");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BirthYear = "19BBY",
                            EyeColor = "blue",
                            Gender = "male",
                            HairColor = "blond",
                            Height = "172",
                            Name = "Luke Skywalker",
                            PlanetId = 1,
                            SkinColor = "fair",
                            Weight = "77"
                        },
                        new
                        {
                            Id = 2,
                            BirthYear = "112BBY",
                            EyeColor = "yellow",
                            Gender = "n/a",
                            HairColor = "n/a",
                            Height = "167",
                            Name = "C-3PO",
                            PlanetId = 1,
                            SkinColor = "gold",
                            Weight = "75"
                        },
                        new
                        {
                            Id = 3,
                            BirthYear = "33BBY",
                            EyeColor = "red",
                            Gender = "n/a",
                            HairColor = "n/a",
                            Height = "96",
                            Name = "R2-D2",
                            PlanetId = 8,
                            SkinColor = "white, blue",
                            Weight = "32"
                        },
                        new
                        {
                            Id = 4,
                            BirthYear = "41.9BBY",
                            EyeColor = "yellow",
                            Gender = "male",
                            HairColor = "none",
                            Height = "202",
                            Name = "Darth Vader",
                            PlanetId = 1,
                            SkinColor = "white",
                            Weight = "136"
                        },
                        new
                        {
                            Id = 5,
                            BirthYear = "19BBY",
                            EyeColor = "brown",
                            Gender = "female",
                            HairColor = "brown",
                            Height = "150",
                            Name = "Leia Organa",
                            PlanetId = 2,
                            SkinColor = "light",
                            Weight = "49"
                        },
                        new
                        {
                            Id = 6,
                            BirthYear = "52BBY",
                            EyeColor = "blue",
                            Gender = "male",
                            HairColor = "brown, grey",
                            Height = "178",
                            Name = "Owen Lars",
                            PlanetId = 1,
                            SkinColor = "light",
                            Weight = "120"
                        },
                        new
                        {
                            Id = 7,
                            BirthYear = "47BBY",
                            EyeColor = "blue",
                            Gender = "female",
                            HairColor = "brown",
                            Height = "165",
                            Name = "Beru Whitesun lars",
                            PlanetId = 1,
                            SkinColor = "light",
                            Weight = "75"
                        },
                        new
                        {
                            Id = 8,
                            BirthYear = "unknown",
                            EyeColor = "red",
                            Gender = "n/a",
                            HairColor = "n/a",
                            Height = "97",
                            Name = "R5-D4",
                            PlanetId = 1,
                            SkinColor = "white, red",
                            Weight = "32"
                        },
                        new
                        {
                            Id = 9,
                            BirthYear = "24BBY",
                            EyeColor = "brown",
                            Gender = "male",
                            HairColor = "black",
                            Height = "183",
                            Name = "Biggs Darklighter",
                            PlanetId = 1,
                            SkinColor = "light",
                            Weight = "84"
                        });
                });

            modelBuilder.Entity("May.The.Fourth.Backend.Data.Entities.FilmPlanetEntity", b =>
                {
                    b.Property<int>("PlanetId")
                        .HasColumnType("INT")
                        .HasColumnName("PlanetID");

                    b.HasKey("PlanetId");

                    b.ToTable("FilmsPlanets");

                    b.HasData(
                        new
                        {
                            PlanetId = 1
                        },
                        new
                        {
                            PlanetId = 2
                        },
                        new
                        {
                            PlanetId = 3
                        },
                        new
                        {
                            PlanetId = 4
                        },
                        new
                        {
                            PlanetId = 5
                        },
                        new
                        {
                            PlanetId = 6
                        },
                        new
                        {
                            PlanetId = 7
                        },
                        new
                        {
                            PlanetId = 8
                        },
                        new
                        {
                            PlanetId = 9
                        },
                        new
                        {
                            PlanetId = 10
                        });
                });

            modelBuilder.Entity("May.The.Fourth.Backend.Data.Entities.FilmeEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT")
                        .HasColumnName("FilmeID");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("DataLancamento")
                        .HasColumnType("DATE")
                        .HasColumnName("DataLancamento");

                    b.Property<string>("Diretor")
                        .HasColumnType("VARCHAR(150)")
                        .HasColumnName("Diretor");

                    b.Property<int?>("Episodio")
                        .HasColumnType("INT")
                        .HasColumnName("Episodio");

                    b.Property<string>("Produtor")
                        .HasColumnType("VARCHAR(150)")
                        .HasColumnName("Produtor");

                    b.Property<string>("TextoAbertura")
                        .HasColumnType("VARCHAR(500)")
                        .HasColumnName("TextoAbertura");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("VARCHAR(500)")
                        .HasColumnName("Titulo");

                    b.HasKey("Id");

                    b.ToTable("Filmes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DataLancamento = new DateTime(2028, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Diretor = "Jana Doe",
                            Episodio = 10,
                            Produtor = "Leo Smith",
                            TextoAbertura = "After the fall of the Empire, the galaxy face",
                            Titulo = "The Rise of the Jedi"
                        },
                        new
                        {
                            Id = 2,
                            Titulo = "The Battle of the Stars"
                        },
                        new
                        {
                            Id = 3,
                            Titulo = "Return of the Light"
                        },
                        new
                        {
                            Id = 4,
                            Titulo = "Warriors of the Shadow Realm"
                        },
                        new
                        {
                            Id = 5,
                            Titulo = "The Galactic Quest"
                        },
                        new
                        {
                            Id = 6,
                            Titulo = "Rise of the Planetara"
                        },
                        new
                        {
                            Id = 7,
                            Titulo = "Echoes of the Stars"
                        },
                        new
                        {
                            Id = 8,
                            Titulo = "The Return of the Voyager"
                        },
                        new
                        {
                            Id = 9,
                            Titulo = "Voyager's Endgame"
                        },
                        new
                        {
                            Id = 10,
                            Titulo = "Galactic Odyssey"
                        },
                        new
                        {
                            Id = 11,
                            Titulo = "The Edge of the Universe"
                        });
                });

            modelBuilder.Entity("May.The.Fourth.Backend.Data.Entities.PlanetEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT")
                        .HasColumnName("PlanetID");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Climate")
                        .IsRequired()
                        .HasColumnType("VARCHAR(150)")
                        .HasColumnName("Climate");

                    b.Property<string>("Diameter")
                        .IsRequired()
                        .HasColumnType("VARCHAR(15)")
                        .HasColumnName("Diameter");

                    b.Property<string>("Gravity")
                        .IsRequired()
                        .HasColumnType("VARCHAR(150)")
                        .HasColumnName("Gravity");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("VARCHAR(150)")
                        .HasColumnName("Name");

                    b.Property<string>("OrbitalPeriod")
                        .IsRequired()
                        .HasColumnType("VARCHAR(10)")
                        .HasColumnName("OrbitalPeriod");

                    b.Property<string>("Population")
                        .IsRequired()
                        .HasColumnType("VARCHAR(15)")
                        .HasColumnName("Population");

                    b.Property<string>("RotationPeriod")
                        .IsRequired()
                        .HasColumnType("VARCHAR(10)")
                        .HasColumnName("RotationPeriod");

                    b.Property<string>("SurfaceWater")
                        .IsRequired()
                        .HasColumnType("VARCHAR(10)")
                        .HasColumnName("SurfaceWater");

                    b.Property<string>("Terrain")
                        .IsRequired()
                        .HasColumnType("VARCHAR(150)")
                        .HasColumnName("Terrain");

                    b.HasKey("Id");

                    b.ToTable("Planets");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Climate = "arid",
                            Diameter = "10465",
                            Gravity = "1 standard",
                            Name = "Tatooine",
                            OrbitalPeriod = "304",
                            Population = "200000",
                            RotationPeriod = "23",
                            SurfaceWater = "1",
                            Terrain = "desert"
                        },
                        new
                        {
                            Id = 2,
                            Climate = "temperate",
                            Diameter = "12500",
                            Gravity = "1 standard",
                            Name = "Alderaan",
                            OrbitalPeriod = "364",
                            Population = "2000000000",
                            RotationPeriod = "24",
                            SurfaceWater = "40",
                            Terrain = "grasslands, mountains"
                        },
                        new
                        {
                            Id = 3,
                            Climate = "temperate, tropical",
                            Diameter = "10200",
                            Gravity = "1 standard",
                            Name = "Yavin IV",
                            OrbitalPeriod = "4818",
                            Population = "1000",
                            RotationPeriod = "24",
                            SurfaceWater = "8",
                            Terrain = "jungle, rainforests"
                        },
                        new
                        {
                            Id = 4,
                            Climate = "frozen",
                            Diameter = "7200",
                            Gravity = "1.1 standard",
                            Name = "Hoth",
                            OrbitalPeriod = "549",
                            Population = "unknown",
                            RotationPeriod = "23",
                            SurfaceWater = "100",
                            Terrain = "tundra, ice caves, mountain ranges"
                        },
                        new
                        {
                            Id = 5,
                            Climate = "murky",
                            Diameter = "8900",
                            Gravity = "N/A",
                            Name = "Dagobah",
                            OrbitalPeriod = "341",
                            Population = "unknown",
                            RotationPeriod = "23",
                            SurfaceWater = "8",
                            Terrain = "swamp, jungles"
                        },
                        new
                        {
                            Id = 6,
                            Climate = "temperate",
                            Diameter = "118000",
                            Gravity = "1.5 (surface), 1 standard (Cloud City)",
                            Name = "Bespin",
                            OrbitalPeriod = "5110",
                            Population = "6000000",
                            RotationPeriod = "12",
                            SurfaceWater = "0",
                            Terrain = "gas giant"
                        },
                        new
                        {
                            Id = 7,
                            Climate = "temperate",
                            Diameter = "4900",
                            Gravity = "0.85 standard",
                            Name = "Endor",
                            OrbitalPeriod = "402",
                            Population = "30000000",
                            RotationPeriod = "18",
                            SurfaceWater = "8",
                            Terrain = "forests, mountains, lakes"
                        },
                        new
                        {
                            Id = 8,
                            Climate = "temperate",
                            Diameter = "12120",
                            Gravity = "1 standard",
                            Name = "Naboo",
                            OrbitalPeriod = "312",
                            Population = "4500000000",
                            RotationPeriod = "26",
                            SurfaceWater = "12",
                            Terrain = "grassy hills, swamps, forests, mountains"
                        },
                        new
                        {
                            Id = 9,
                            Climate = "temperate",
                            Diameter = "12240",
                            Gravity = "1 standard",
                            Name = "Coruscant",
                            OrbitalPeriod = "368",
                            Population = "1000000000000",
                            RotationPeriod = "24",
                            SurfaceWater = "unknown",
                            Terrain = "cityscape, mountains"
                        },
                        new
                        {
                            Id = 10,
                            Climate = "temperate",
                            Diameter = "19720",
                            Gravity = "1 standard",
                            Name = "Kamino",
                            OrbitalPeriod = "463",
                            Population = "1000000000",
                            RotationPeriod = "27",
                            SurfaceWater = "100",
                            Terrain = "ocean"
                        });
                });

            modelBuilder.Entity("May.The.Fourth.Backend.Data.Entities.CharacterEntity", b =>
                {
                    b.HasOne("May.The.Fourth.Backend.Data.Entities.PlanetEntity", "Planet")
                        .WithMany("Characters")
                        .HasForeignKey("PlanetId");

                    b.Navigation("Planet");
                });

            modelBuilder.Entity("May.The.Fourth.Backend.Data.Entities.FilmPlanetEntity", b =>
                {
                    b.HasOne("May.The.Fourth.Backend.Data.Entities.PlanetEntity", "Planet")
                        .WithMany("FilmsPlanets")
                        .HasForeignKey("PlanetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Planet");
                });

            modelBuilder.Entity("May.The.Fourth.Backend.Data.Entities.PlanetEntity", b =>
                {
                    b.Navigation("Characters");

                    b.Navigation("FilmsPlanets");
                });
#pragma warning restore 612, 618
        }
    }
}
