using May.The.Fourth.Backend.Data.Interfaces;
using May.The.Fourth.Backend.Services.Interfaces;
using May.The.Fourth.Backend.Services.Mappers;
using May.The.Fourth.Backend.Services.Messages;

namespace May.The.Fourth.Backend.Services
{
    public class FilmService : IFilmService
    {
        private readonly IFilmRepository filmRepository;

        public FilmService(IFilmRepository filmRepository)
        {
            this.filmRepository = filmRepository;
        }

        public async Task<FilmListResponse> GetFilmsAsync()
        {
            try
            {
                FilmListResponse filmListResponse = new FilmListResponse();
                var films = await filmRepository.GetFilmsAsync();
                if (films.Any())
                {
                    filmListResponse.Success = true;
                    filmListResponse.Message = "SUCCESS";
                    filmListResponse.StatusCode = 200;
                    filmListResponse.FilmDtos = MapperDto.MapToFilmDto(films);
                }
                else
                {
                    filmListResponse.Success = false;
                    filmListResponse.Message = "FAILED";
                    filmListResponse.StatusCode = 500;
                    filmListResponse.FilmDtos = null;
                }
                return filmListResponse;
            }
            catch(Exception)
            {
                return new FilmListResponse
                {
                    Success = false,
                    Message = "Internal server error",
                    StatusCode = 500,
                    FilmDtos = null
                };
            }
        }

         public async Task<FilmGetResponse> GetFilmByIdAsync(int id)
        {
            try
            {
                FilmGetResponse filmGetResponse = new FilmGetResponse();
                var film = await filmRepository.GetFilmByIdAsync(id);
                if (film != null)
                {
                    filmGetResponse.Success = true;
                    filmGetResponse.Message = "SUCCESS";
                    filmGetResponse.StatusCode = 200;
                    filmGetResponse.FilmDto = MapperDto.MapToFilmDto(film);
                }
                else
                {
                    filmGetResponse.Success = false;
                    filmGetResponse.Message = "FAILED";
                    filmGetResponse.StatusCode = 500;
                    filmGetResponse.FilmDto = null;
                }
                return filmGetResponse;
            }
            catch(Exception)
            {
                return new FilmGetResponse
                {
                    Success = false,
                    Message = "Internal server error",
                    StatusCode = 500,
                    FilmDto = null
                };
            }
        }
    }  
}