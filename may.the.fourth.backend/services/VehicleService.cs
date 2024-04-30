using May.The.Fourth.Backend.Data.Interfaces;
using May.The.Fourth.Backend.Services.Interfaces;
using May.The.Fourth.Backend.Services.Mappers;
using May.The.Fourth.Backend.Services.Messages;

namespace May.The.Fourth.Backend.Services
{
    public class VehicleService : IVehicleService
    {
        private readonly IVehicleRepository vehicleRepository;

        public VehicleService(IVehicleRepository vehicleRepository)
        {
            this.vehicleRepository = vehicleRepository;
        }

        public async Task<VehicleListResponse> GetVehiclesAsync()
        {
            try
            {
                VehicleListResponse vehicleListResponse = new VehicleListResponse();
                var vehicles = await vehicleRepository.GetVehiclesAsync();
                if (vehicles.Any())
                {
                    vehicleListResponse.Success = true;
                    vehicleListResponse.Message = "SUCCESS";
                    vehicleListResponse.StatusCode = 200;
                    vehicleListResponse.VehicleDtos = MapperDto.MapToVehicleDto(vehicles);
                }
                else
                {
                    vehicleListResponse.Success = false;
                    vehicleListResponse.Message = "FAILED";
                    vehicleListResponse.StatusCode = 500;
                    vehicleListResponse.VehicleDtos = null;
                }
                return vehicleListResponse;
            }
            catch(Exception)
            {
                return new VehicleListResponse
                {
                    Success = false,
                    Message = "Internal server error",
                    StatusCode = 500,
                    VehicleDtos = null
                };
            }
        }

        public async Task<VehicleGetResponse> GetVehicleByIdAsync(int id)
        {
            try
            {
                VehicleGetResponse vehicleGetResponse = new VehicleGetResponse();
                var vehicle = await vehicleRepository.GetVehicleByIdAsync(id);
                if (vehicle != null)
                {
                    vehicleGetResponse.Success = true;
                    vehicleGetResponse.Message = "SUCCESS";
                    vehicleGetResponse.StatusCode = 200;
                    vehicleGetResponse.VehicleDto = MapperDto.MapToVehicleDto(vehicle);
                }
                else
                {
                    vehicleGetResponse.Success = false;
                    vehicleGetResponse.Message = "FAILED";
                    vehicleGetResponse.StatusCode = 500;
                    vehicleGetResponse.VehicleDto = null;
                }
                return vehicleGetResponse;
            }
            catch(Exception)
            {
                return new VehicleGetResponse
                {
                    Success = false,
                    Message = "Internal server error",
                    StatusCode = 500,
                    VehicleDto = null
                };
            }
        }
    }  
}