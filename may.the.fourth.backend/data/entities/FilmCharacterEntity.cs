using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace May.The.Fourth.Backend.Data.Entities;

[Table("FilmsCharacters")]
public class FilmCharacterEntity
{
    [Key]
    [Column("FilmID", TypeName = "INT")]
    [ForeignKey("Film")]
    public int FilmId { get; set; }

    public FilmEntity? Film { get; set; }

    [Key]
    [Column("CharacterID", TypeName = "INT")]
    [ForeignKey("Character")]
    public int CharacterId { get; set; }

    public CharacterEntity? Character { get; set; }
}