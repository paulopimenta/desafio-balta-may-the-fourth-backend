﻿namespace May.The.Fourth.Backend.Domain.Model;

public class Planet
{
    public int Id { get; set; }
    public string Name { get; set; } = String.Empty;
    public string RotationPeriod { get; set; } = String.Empty;
    public string OrbitalPeriod { get; set; } = String.Empty;
    public string Diameter { get; set; } = String.Empty;
    public string Climate { get; set; } = String.Empty;
    public string Gravity { get; set; } = String.Empty;
    public string Terrain { get; set; } = String.Empty;
    public string SurfaceWater { get; set; } = String.Empty;
    public string Population { get; set; } = String.Empty;
    public IList<Character>? Characters { get; set; }
}