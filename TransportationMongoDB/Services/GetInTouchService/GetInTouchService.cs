using AutoMapper;
using DatabaseMastery.TransportMongoDb.Entities;
using MongoDB.Driver;
using TransportationMongoDB.Dtos.GetInTouchDtos;
using TransportationMongoDB.Entities;
using TransportationMongoDB.Settings;

namespace TransportationMongoDB.Services.GetInTouchService
{
    public class GetInTouchService : IGetInTouchService
    {
        private readonly IMongoCollection<GetInTouch> _getInTouchCollection;
        private readonly IMapper _mapper;

        public GetInTouchService(IMapper mapper, IDatabaseSettings _databaseSettings)
        {
            var client = new MongoClient(_databaseSettings.ConnectionString);
            var database = client.GetDatabase(_databaseSettings.DatabaseName);
            _getInTouchCollection = database.GetCollection<GetInTouch>(_databaseSettings.GetInTouchCollectionName);

            _mapper = mapper;
        }

        public async Task CreateGetInTouchAsync(CreateGetInTouchDto createGetInTouchDto)
        {
            var value = _mapper.Map<GetInTouch>(createGetInTouchDto);
            await _getInTouchCollection.InsertOneAsync(value);
        }

        public async Task DeleteGetInTouchAsync(string id)
        {
            await _getInTouchCollection.DeleteOneAsync(x => x.GetInTouchId == id);
        }

        public async Task<List<ResultGetInTouchDto>> GetAllGetInTouchsAsync()
        {
            var values = await _getInTouchCollection.Find(x => true).ToListAsync();
            return _mapper.Map<List<ResultGetInTouchDto>>(values);
        }

        public async Task<GetInTouchByIdDto> GetGetInTouchByIdAsync(string id)
        {
            var value = await _getInTouchCollection.Find(x => x.GetInTouchId == id).FirstOrDefaultAsync();
            return _mapper.Map<GetInTouchByIdDto>(value);
        }

        public async Task UpdateGetInTouchAsync(UpdateGetInTouchDto updateGetInTouchDto)
        {
            var value = _mapper.Map<GetInTouch>(updateGetInTouchDto);
            await _getInTouchCollection.FindOneAndReplaceAsync(x => x.GetInTouchId == updateGetInTouchDto.GetInTouchId, value);
        }
    }
}
