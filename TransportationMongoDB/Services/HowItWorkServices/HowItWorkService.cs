using AutoMapper;
using DatabaseMastery.TransportMongoDb.Entities;
using MongoDB.Driver;
using TransportationMongoDB.Dtos.HowItWorkDtos;
using TransportationMongoDB.Entities;
using TransportationMongoDB.Settings;

namespace DatabaseMastery.TransportMongoDb.Services.HowItWorkServices
{
    public class HowItWorkService : IHowItWorkService
    {
        private readonly IMongoCollection<HowItWork> _howItWorkCollection;
        private readonly IMapper _mapper;

        public HowItWorkService(IMapper mapper, IDatabaseSettings _databaseSettings)
        {
            var client = new MongoClient(_databaseSettings.ConnectionString);
            var database = client.GetDatabase(_databaseSettings.DatabaseName);
            _howItWorkCollection = database.GetCollection<HowItWork>(_databaseSettings.HowItWorkCollectionName);
            _mapper = mapper;
        }
        public async Task CreateHowItWorkAsync(CreateHowItWorkDto createHowItWorkDto)
        {
            var value = _mapper.Map<HowItWork>(createHowItWorkDto);
            await _howItWorkCollection.InsertOneAsync(value);
        }
        public async Task DeleteHowItWorkAsync(string id)
        {
            await _howItWorkCollection.DeleteOneAsync(x => x.HowItWorkId == id);
        }
        public async Task<List<ResultHowItWorkDto>> GetAllHowItWorkAsync()
        {
            var values = await _howItWorkCollection.Find(x => true).ToListAsync();
            return _mapper.Map<List<ResultHowItWorkDto>>(values);
        }
        public async Task<GetHowItWorkByIdDto> GetHowItWorkByIdAsync(string id)
        {
            var value = await _howItWorkCollection.Find(x => x.HowItWorkId == id).FirstOrDefaultAsync();
            return _mapper.Map<GetHowItWorkByIdDto>(value);
        }
        public async Task UpdateHowItWorkAsync(UpdateHowItWorkDto updateHowItWorkDto)
        {
            var values = _mapper.Map<HowItWork>(updateHowItWorkDto);
            await _howItWorkCollection.FindOneAndReplaceAsync(x => x.HowItWorkId == updateHowItWorkDto.HowItWorkId, values);
        }
    }
}
