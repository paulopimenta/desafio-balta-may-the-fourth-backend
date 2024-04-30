using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace May.The.Fourth.Backend.Data.Entities;

[Table("Starship")]
public class StarshipEntity
{
    [Column("StarshipID", TypeName = "INT")]
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    [Column("Name", TypeName = "VARCHAR(150)")]
    [Required(ErrorMessage = "Name is required")]
    public string Name { get; set; } = string.Empty;

    [Column("Model", TypeName = "VARCHAR(150)")]
    [Required(ErrorMessage = "Model is required")]
    public string Model { get; set; } = string.Empty;

    [Column("Manufacturer", TypeName = "VARCHAR(150)")]
    [Required(ErrorMessage = "Manufacturer is required")]
    public string Manufacturer { get; set; } = string.Empty;

    [Column("CostInCredits", TypeName = "VARCHAR(20)")]
    [Required(ErrorMessage = "CostInCredits is required")]
    public string CostInCredits { get; set; } = string.Empty;

    [Column("Length", TypeName = "VARCHAR(50)")]
    [Required(ErrorMessage = "Length is required")]
    public string Length { get; set; } = string.Empty;

    [Column("MaxAtmospheringSpeed", TypeName = "VARCHAR(50)")]
    [Required(ErrorMessage = "MaxAtmospheringSpeed is required")]
    public string MaxAtmospheringSpeed { get; set; } = string.Empty;

    [Column("Crew", TypeName = "VARCHAR(20)")]
    [Required(ErrorMessage = "Crew is required")]
    public string Crew { get; set; } = string.Empty;

    [Column("Passengers", TypeName = "VARCHAR(20)")]
    [Required(ErrorMessage = "Passengers is required")]
    public string Passengers { get; set; } = string.Empty;

    [Column("CargoCapacity", TypeName = "VARCHAR(50)")]
    [Required(ErrorMessage = "CargoCapacity is required")]
    public string CargoCapacity { get; set; } = string.Empty;

    [Column("Consumables", TypeName = "VARCHAR(50)")]
    [Required(ErrorMessage = "Consumables is required")]
    public string Consumables { get; set; } = string.Empty;

    [Column("HyperdriveRating", TypeName = "VARCHAR(20)")]
    [Required(ErrorMessage = "HyperdriveRating is required")]
    public string HyperdriveRating { get; set; } = string.Empty;

    [Column("MGLT", TypeName = "VARCHAR(20)")]
    [Required(ErrorMessage = "MGLT is required")]
    public string MGLT { get; set; } = string.Empty;

    [Column("StarshipClass", TypeName = "VARCHAR(50)")]
    [Required(ErrorMessage = "StarshipClass is required")]
    public string StarshipClass { get; set; } = string.Empty;
}