using TransportationMongoDB.Dtos.ShipmentTrackingDtos;

namespace DatabaseMastery.TransportMongoDb.Services.ShipmentTrackingServices
{
    public interface IShipmentTrackingService
    {
        Task<List<ResultShipmentTrackingDto>> GetAllTrackingsAsync(string trackingNumber);

        Task CreateTrackingAsync(CreateShipmentTrackingDto createDto);

        Task<ResultShipmentTrackingDto> GetTrackingByIndexAsync(string trackingNumber, int index);

        Task UpdateTrackingAsync(UpdateShipmentTrackingDto updateDto);

        Task DeleteTrackingAsync(string trackingNumber, int index);
    }
}
