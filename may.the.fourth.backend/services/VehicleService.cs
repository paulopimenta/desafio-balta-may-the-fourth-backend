using May.The.Fourth.Backend.Data.Interfaces;
using May.The.Fourth.Backend.Services.Interfaces;
using May.The.Fourth.Backend.Services.Mappers;
using May.The.Fourth.Backend.Services.Messages;

namespace May.The.Fourth.Backend.Services;

public class VehicleService: IVehicleService
{
    private readonly IVehicleRepository vehicleRepository;

    public VehicleService(IVehicleRepository vehicleRepository)
    {
        this.vehicleRepository = vehicleRepository;
    }

    public async Task<VehicleListResponse> GetVehicles()
    {
        try
        {
            VehicleListResponse vehicleListResponse = new VehicleListResponse();
            var vehicles = await vehicleRepository.GetVehicles();
            if (vehicles.Any())
            {
                vehicleListResponse.Success = true;
                vehicleListResponse.Message = "SUCCESS";
                vehicleListResponse.StatusCode = 200;
                vehicleListResponse.VehicleDto = MapperDto.MapToVehicleDto(vehicles);
            }
            else
            {
                vehicleListResponse.Success = false;
                vehicleListResponse.Message = "FAILED";
                vehicleListResponse.StatusCode = 500;
                vehicleListResponse.VehicleDto = null;
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
                VehicleDto = null
            };
        }
    }
}
