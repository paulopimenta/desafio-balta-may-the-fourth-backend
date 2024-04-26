using May.The.Fourth.Backend.Data.Interfaces;
using May.The.Fourth.Backend.Services.Interfaces;
using May.The.Fourth.Backend.Services.Mappers;
using May.The.Fourth.Backend.Services.Messages;

namespace May.The.Fourth.Backend.Services
{
    public class PlanetService : IPlanetService
    {
        private readonly IPlanetRepository planetRepository;

        public PlanetService(IPlanetRepository planetRepository)
        {
            this.planetRepository = planetRepository;
        }

        public async Task<PlanetListResponse> GetPlanets()
        {
            try
            {
                PlanetListResponse planetListResponse = new PlanetListResponse();
                var planets = await planetRepository.GetPlanets();
                if (planets.Any())
                {
                    planetListResponse.Success = true;
                    planetListResponse.Message = "SUCCESS";
                    planetListResponse.StatusCode = 200;
                    planetListResponse.PlanetDto = MapperDto.MapToPlanetDto(planets);
                }
                else
                {
                    planetListResponse.Success = false;
                    planetListResponse.Message = "FAILED";
                    planetListResponse.StatusCode = 500;
                    planetListResponse.PlanetDto = null;
                }
                return planetListResponse;
            }
            catch(Exception)
            {
                return new PlanetListResponse
                {
                    Success = false,
                    Message = "Internal server error",
                    StatusCode = 500,
                    PlanetDto = null
                };
            }
        }
    }  
}