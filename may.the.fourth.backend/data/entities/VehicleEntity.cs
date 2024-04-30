using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace May.The.Fourth.Backend.Data.Entities;

[Table("Vehicles")]
public class VehicleEntity
{
    [Column("VehiclesID", TypeName = "INT")]
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

    [Column("CostInCredits", TypeName = "VARCHAR(10)")]
    [Required(ErrorMessage = "CostInCredits is required")]
    public string CostInCredits { get; set; } = string.Empty;

    [Column("Length", TypeName = "VARCHAR(50)")]
    [Required(ErrorMessage = "Length is required")]
    public string Length { get; set; } = string.Empty;

    [Column("MaxAtmospheringSpeed", TypeName = "VARCHAR(50)")]
    [Required(ErrorMessage = "MaxAtmospheringSpeed is required")]
    public string MaxAtmospheringSpeed { get; set; } = string.Empty;

    [Column("Crew", TypeName = "VARCHAR(10)")]
    [Required(ErrorMessage = "Crew is required")]
    public string Crew { get; set; } = string.Empty;

    [Column("Passengers", TypeName = "VARCHAR(10)")]
    [Required(ErrorMessage = "Passengers is required")]
    public string Passengers { get; set; } = string.Empty;

    [Column("CargoCapacity", TypeName = "VARCHAR(50)")]
    [Required(ErrorMessage = "CargoCapacity is required")]
    public string CargoCapacity { get; set; } = string.Empty;

    [Column("Consumables", TypeName = "VARCHAR(50)")]
    [Required(ErrorMessage = "Consumables is required")]
    public string Consumables { get; set; } = string.Empty;

    [Column("Vehicle_Class", TypeName = "VARCHAR(50)")]
    [Required(ErrorMessage = "Vehicle_Class is required")]
    public string Vehicle_Class { get; set; } = string.Empty;
}