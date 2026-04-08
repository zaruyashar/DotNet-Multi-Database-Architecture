using TransportationMongoDB.Dtos.OfferDtos;

namespace TransportationMongoDB.Services.OfferServices
{
    public interface IOfferService
    {
        Task<List<ResultOfferDto>> GetAllOffersAsync();
        Task CreateOfferAsync(CreateOfferDto createOfferDto);
        Task UpdateOfferAsync(UpdateOfferDto updateOfferDto);
        Task<GetOfferByIdDto> GetOfferByIdAsync(string id);
        Task DeleteOfferAsync(string id);
    }
}
