namespace May.The.Fourth.Backend.Services.Mappers;

public class VehicleDto
{
    public int Id { get; set; }        
    public string Name { get; set; } = String.Empty;
    public string Model { get; set; } = String.Empty;
    public string Manufacturer { get; set; } = String.Empty;
    public string CostInCredits { get; set; } = String.Empty;
    public string Length { get; set; } = String.Empty;
    public string MaxSpeed { get; set; } = String.Empty;
    public string Crew { get; set; } = String.Empty;
    public string Passengers { get; set; } = String.Empty;
    public string CargoCapacity { get; set; } = String.Empty;
    public string Consumables { get; set; } = String.Empty;
    public string Class { get; set; } = String.Empty;
}