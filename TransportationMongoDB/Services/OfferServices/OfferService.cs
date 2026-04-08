using AutoMapper;
using MongoDB.Driver;
using TransportationMongoDB.Dtos.OfferDtos;
using TransportationMongoDB.Entities;
using TransportationMongoDB.Settings;

namespace TransportationMongoDB.Services.OfferServices
{
    public class OfferService : IOfferService
    {
        private readonly IMongoCollection<Offer> _offerCollection;
        private readonly IMapper _mapper;

        public OfferService(IMapper mapper, IDatabaseSettings _databaseSettings)
        {
            var client = new MongoClient(_databaseSettings.ConnectionString);
            var database = client.GetDatabase(_databaseSettings.DatabaseName);
            _offerCollection = database.GetCollection<Offer>(_databaseSettings.OfferCollectionName);

            _mapper = mapper;
        }

        public async Task CreateOfferAsync(CreateOfferDto createOfferDto)
        {
            var value = _mapper.Map<Offer>(createOfferDto);
            await _offerCollection.InsertOneAsync(value);
        }

        public async Task DeleteOfferAsync(string id)
        {
            await _offerCollection.DeleteOneAsync(x => x.OfferId == id);
        }

        public async Task<List<ResultOfferDto>> GetAllOffersAsync()
        {
            var values = await _offerCollection.Find(x => true).ToListAsync();
            return _mapper.Map<List<ResultOfferDto>>(values);
        }

        public async Task<GetOfferByIdDto> GetOfferByIdAsync(string id)
        {
            var value = await _offerCollection.Find(x => x.OfferId == id).FirstOrDefaultAsync();
            return _mapper.Map<GetOfferByIdDto>(value);
        }

        public async Task UpdateOfferAsync(UpdateOfferDto updateOfferDto)
        {
            var value = _mapper.Map<Offer>(updateOfferDto);
            await _offerCollection.FindOneAndReplaceAsync(x => x.OfferId == updateOfferDto.OfferId, value);
        }
    }
}
