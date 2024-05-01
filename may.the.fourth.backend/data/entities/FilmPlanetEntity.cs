﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace May.The.Fourth.Backend.Data.Entities;

[Table("FilmsPlanets")]
public class FilmPlanetEntity
{
    [Key]
    [Column("FilmID", TypeName = "INT")]
    [ForeignKey("Film")]
    public int FilmId { get; set; }

    public FilmEntity? Film { get; set; }
    
    [Key]
    [Column("PlanetID", TypeName = "INT")]
    [ForeignKey("Planet")]
    public int PlanetId { get; set; }

    public PlanetEntity? Planet { get; set; }
}