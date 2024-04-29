using May.The.Fourth.Backend.Data.Entities;

namespace May.The.Fourth.Backend.Domain.Model;

public class Character
{
    public int Id { get; set; }    
    public string Name { get; set; } = String.Empty;
    public string Height { get; set; } = String.Empty;
    public string Weight { get; set; } = String.Empty;
    public string HairColor { get; set; } = String.Empty;
    public string SkinColor { get; set; } = String.Empty;
    public string EyeColor { get; set; } = String.Empty;
    public string BirthYear { get; set; } = String.Empty;
    public string Gender { get; set; } = String.Empty;
    public PlanetEntity? Planet { get; set; }
}