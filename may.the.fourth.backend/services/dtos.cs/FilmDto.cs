using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace May.The.Fourth.Backend.Services.Mappers
{
    public class FilmDto
    {
        public int Id { get; set; }        
        public string Title { get; set; } = String.Empty;
        public int? Episode { get; set; }
        
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? OpeningCrawl { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Director { get; set; } 
        
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Producer { get; set; } 
        
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime? ReleaseDate { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("characters")]
        public IList<CharacterDto>? CharactersDto { get; set; }
    }
}