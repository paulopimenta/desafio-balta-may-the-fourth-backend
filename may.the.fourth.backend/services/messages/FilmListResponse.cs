using May.The.Fourth.Backend.Services.Mappers;

namespace May.The.Fourth.Backend.Services.Messages
{
    public class FilmListResponse : ResponseBase
    {
        public IList<FilmDto>? FilmDtos { get; set; }
    }
}