using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace May.The.Fourth.Backend.Data.Entities;

[Table("Characters")]
public class CharacterEntity
{
    [Column("CharacterID", TypeName = "INT")]
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    [Column("Name", TypeName = "VARCHAR(150)")]
    [Required(ErrorMessage = "Name is required")]
    public string Name { get; set; } = string.Empty;

    [Column("Height", TypeName = "VARCHAR(10)")]
    [Required(ErrorMessage = "Height is required")]
    public string Height { get; set; } = string.Empty;

    [Column("Weight", TypeName = "VARCHAR(10)")]
    [Required(ErrorMessage = "Weight is required")]
    public string Weight { get; set; } = string.Empty;

    [Column("HairColor", TypeName = "VARCHAR(50)")]
    [Required(ErrorMessage = "HairColor is required")]
    public string HairColor { get; set; } = string.Empty;

    [Column("SkinColor", TypeName = "VARCHAR(50)")]
    [Required(ErrorMessage = "SkinColor is required")]
    public string SkinColor { get; set; } = string.Empty;

    [Column("EyeColor", TypeName = "VARCHAR(50)")]
    [Required(ErrorMessage = "EyeColor is required")]
    public string EyeColor { get; set; } = string.Empty;

    [Column("BirthYear", TypeName = "VARCHAR(50)")]
    [Required(ErrorMessage = "BirthYear is required")]
    public string BirthYear { get; set; } = string.Empty;

    [Column("Gender", TypeName = "VARCHAR(20)")]
    [Required(ErrorMessage = "Gender is required")]
    public string Gender { get; set; } = string.Empty;

    // Navigation properties                
    [Column("PlanetID", TypeName = "INT")]
    [ForeignKey("Planet")]
    public int? PlanetId { get; set; }

    public virtual PlanetEntity? Planet { get; set; }
}