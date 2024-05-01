namespace May.The.Fourth.Backend.Domain.Model;

public class Film
{
    public int Id { get; set; }    
    public string Title { get; set; } = string.Empty;
    public int Episode { get; set; } = 0;
    public string OpeningCrawl  { get; set; } = string.Empty;
    public string Director{ get; set; } = string.Empty;
    public string Producer{ get; set; } = string.Empty;
    public DateTime? ReleaseDate{ get; set; }
    public IList<Character>? Characters { get; set; }
    //public IList<Planet>? Planets { get; set; }
    //public IList<Vehicle>? Vehicles { get; set; }
    //public IList<StarShip>? StarShips { get; set; }
}