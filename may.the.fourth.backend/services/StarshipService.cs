using May.The.Fourth.Backend.Data.Interfaces;
using May.The.Fourth.Backend.Services.Interfaces;
using May.The.Fourth.Backend.Services.Mappers;
using May.The.Fourth.Backend.Services.Messages;

namespace May.The.Fourth.Backend.Services
{
    public class StarshipService : IStarshipService
    {
        private readonly IStarshipRepository starshipRepository;

        public StarshipService(IStarshipRepository starshipRepository)
        {
            this.starshipRepository = starshipRepository;
        }

        public async Task<StarshipListResponse> GetStarshipsAsync()
        {
            try
            {
                StarshipListResponse starshipListResponse = new StarshipListResponse();
                var starships = await starshipRepository.GetStarshipsAsync();
                if (starships.Any())
                {
                    starshipListResponse.Success = true;
                    starshipListResponse.Message = "SUCCESS";
                    starshipListResponse.StatusCode = 200;
                    starshipListResponse.StarshipDtos = MapperDto.MapToStarshipDto(starships);
                }
                else
                {
                    starshipListResponse.Success = false;
                    starshipListResponse.Message = "FAILED";
                    starshipListResponse.StatusCode = 500;
                    starshipListResponse.StarshipDtos = null;
                }
                return starshipListResponse;
            }
            catch(Exception)
            {
                return new StarshipListResponse
                {
                    Success = false,
                    Message = "Internal server error",
                    StatusCode = 500,
                    StarshipDtos = null
                };
            }
        }
    }  
}