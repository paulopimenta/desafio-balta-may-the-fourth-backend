using May.The.Fourth.Backend.Data.Entities;

namespace May.The.Fourth.Backend.Domain.Model;

public class Character
{
    public int Id { get; set; }    
    public string Name { get; set; } = string.Empty;
    public string Height { get; set; } = string.Empty;
    public string Weight { get; set; } = string.Empty;
    public string HairColor { get; set; } = string.Empty;
    public string SkinColor { get; set; } = string.Empty;
    public string EyeColor { get; set; } = string.Empty;
    public string BirthYear { get; set; } = string.Empty;
    public string Gender { get; set; } = string.Empty;
    public virtual PlanetEntity? Planet { get; set; }
}