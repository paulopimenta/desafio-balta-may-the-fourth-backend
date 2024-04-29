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

        public async Task<PlanetListResponse> GetPlanetsAsync()
        {
            try
            {
                PlanetListResponse planetListResponse = new PlanetListResponse();
                var planets = await planetRepository.GetPlanetsAsync();
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

        public async Task<PlanetGetResponse> GetPlanetByIdAsync(int id)
        {
            try
            {
                PlanetGetResponse planetGetResponse = new PlanetGetResponse();
                var planet = await planetRepository.GetPlanetByIdAsync(id);
                if (planet != null)
                {
                    planetGetResponse.Success = true;
                    planetGetResponse.Message = "SUCCESS";
                    planetGetResponse.StatusCode = 200;
                    planetGetResponse.PlanetDto = MapperDto.MapToPlanetDto(planet);
                }
                else
                {
                    planetGetResponse.Success = false;
                    planetGetResponse.Message = "FAILED";
                    planetGetResponse.StatusCode = 500;
                    planetGetResponse.PlanetDto = null;
                }
                return planetGetResponse;
            }
            catch(Exception)
            {
                return new PlanetGetResponse
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