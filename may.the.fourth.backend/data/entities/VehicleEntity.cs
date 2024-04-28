using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace May.The.Fourth.Backend.Data.Entities;

[Table("Vehicles")]
public class VehicleEntity
{    
    [Column("VehicleID", TypeName = "INT")]
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    [Column("Name", TypeName = "VARCHAR(255)")]
    [Required(ErrorMessage = "Name is required")]
    public string Name { get; set; } = String.Empty;

    [Column("Model", TypeName = "VARCHAR(255)")]
    [Required(ErrorMessage = "Model is required")]
    public string Model { get; set; } = String.Empty;

    [Column("Manufacturer", TypeName = "VARCHAR(255)")]
    public string Manufacturer { get; set; } = String.Empty;

    [Column("CostInCredits", TypeName = "VARCHAR(50)")]
    public string CostInCredits { get; set; } = String.Empty;

    [Column("Length", TypeName = "VARCHAR(50)")]
    public string Length { get; set; } = String.Empty;

    [Column("MaxSpeed", TypeName = "VARCHAR(50)")]
    public string MaxSpeed { get; set; } = String.Empty;

    [Column("Crew", TypeName = "VARCHAR(50)")]
    public string Crew { get; set; } = String.Empty;

    [Column("Passengers", TypeName = "VARCHAR(50)")]
    public string Passengers { get; set; } = String.Empty;

    [Column("CargoCapacity", TypeName = "VARCHAR(50)")]
    public string CargoCapacity { get; set; } = String.Empty;

    [Column("Consumables", TypeName = "VARCHAR(50)")]
    public string Consumables { get; set; } = String.Empty;
    
    [Column("Class", TypeName = "VARCHAR(50)")]
    public string Class { get; set; } = String.Empty;            
    
    //public virtual ICollection<FilmVheicleEntity>? FilmVehicle { get; set; }
}
