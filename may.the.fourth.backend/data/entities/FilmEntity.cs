using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace May.The.Fourth.Backend.Data.Entities
{
    [Table("Films")]
    public class FilmEntity
    {
        [Column("FilmID", TypeName = "INT")]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        [Column("Title", TypeName = "VARCHAR(500)")]
        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; } = String.Empty;

        [Column("Episode", TypeName = "INT")]
        [Required(ErrorMessage = "Episode is required")]
        public int Episode { get; set; } = 0 ;

        [Column("OpeningCrawl", TypeName = "VARCHAR(500)")]
        [Required(ErrorMessage = "OpeningCrawl is required")]
        public string OpeningCrawl { get; set; } = string.Empty;

        [Column("Director", TypeName = "VARCHAR(150)")]
        [Required(ErrorMessage = "Director is required")]
        public string Director { get; set; } = string.Empty;

        [Column("Producer", TypeName = "VARCHAR(150)")]
        [Required(ErrorMessage = "Producer is required")]
        public string Producer { get; set; } = string.Empty;

        [Column("ReleaseDate", TypeName = "DATE")]        
        public DateTime? ReleaseDate { get; set; }

        // Navigation properties                
        public virtual ICollection<FilmCharacterEntity>? FilmsCharacters { get; set; }
        public virtual ICollection<CharacterEntity>? Characters { get; set; }
    }
}