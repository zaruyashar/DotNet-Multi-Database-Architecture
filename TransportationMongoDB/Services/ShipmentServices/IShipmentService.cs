using TransportationMongoDB.Dtos.ShipmentDtos;

namespace TransportationMongoDB.Services.ShipmentServices
{
    public interface IShipmentService
    {
        Task<List<ResultShipmentDto>> GetAllShipmentsAsync();
        Task CreateShipmentAsync(CreateShipmentDto createShipmentDto);
        Task UpdateShipmentAsync(UpdateShipmentDto updateShipmentDto);
        Task<GetShipmentByIdDto> GetShipmentByIdAsync(string id);
        Task DeleteShipmentAsync(string id);
        Task<GetShipmentByIdDto> GetShipmentByTrackingNumberAsync(string trackingNumber);
        public Task<long> GetTotalShipmentCountAsync();
        public Task<long> GetDeliveredShipmentCountAsync();
        public Task<int> GetDistinctDestinationCityCountAsync();
        public Task<long> GetInDistributionShipmentCountAsync();
    }
}
