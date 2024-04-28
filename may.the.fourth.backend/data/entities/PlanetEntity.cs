using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace May.The.Fourth.Backend.Data.Entities
{
    [Table("Planets")]
    public class PlanetEntity
    {
        [Column("PlanetID", TypeName = "INT")]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        [Column("Name", TypeName = "VARCHAR(150)")]
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; } = String.Empty;

        [Column("RotationPeriod", TypeName = "VARCHAR(10)")]
        [Required(ErrorMessage = "Rotation Period is required")]
        public string RotationPeriod { get; set; } = String.Empty;

        [Column("OrbitalPeriod", TypeName = "VARCHAR(10)")]
        public string OrbitalPeriod { get; set; } = String.Empty;

        [Column("Diameter", TypeName = "VARCHAR(15)")]
        public string Diameter { get; set; } = String.Empty;

        [Column("Climate", TypeName = "VARCHAR(150)")]
        public string Climate { get; set; } = String.Empty;

        [Column("Gravity", TypeName = "VARCHAR(150)")]
        public string Gravity { get; set; } = String.Empty;

        [Column("Terrain", TypeName = "VARCHAR(150)")]
        public string Terrain { get; set; } = String.Empty;

        [Column("SurfaceWater", TypeName = "VARCHAR(10)")]
        public string SurfaceWater { get; set; } = String.Empty;

        [Column("Population", TypeName = "VARCHAR(15)")]
        public string Population { get; set; } = String.Empty;

        // Navigation properties                
        public virtual ICollection<FilmPlanetEntity>? FilmsPlanets { get; set; }
        public virtual ICollection<CharacterEntity>? Characters { get; set; }
    }
}