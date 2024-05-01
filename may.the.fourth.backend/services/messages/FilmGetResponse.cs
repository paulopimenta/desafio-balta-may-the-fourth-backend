using May.The.Fourth.Backend.Services.Mappers;

namespace May.The.Fourth.Backend.Services.Messages;

public class FilmGetResponse: ResponseBase
{
    public FilmDto? FilmDto { get; set; }
}
