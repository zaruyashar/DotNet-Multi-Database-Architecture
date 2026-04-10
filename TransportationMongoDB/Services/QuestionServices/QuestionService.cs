using AutoMapper;
using MongoDB.Driver;
using TransportationMongoDB.Dtos.QuestionDtos;
using TransportationMongoDB.Entities;
using TransportationMongoDB.Settings;

namespace TransportationMongoDB.Services.QuestionServices
{
    public class QuestionService : IQuestionService
    {
        private readonly IMongoCollection<Question> _questionCollection;
        private readonly IMapper _mapper;

        public QuestionService(IMapper mapper, IDatabaseSettings _databaseSettings)
        {
            var client = new MongoClient(_databaseSettings.ConnectionString);
            var database = client.GetDatabase(_databaseSettings.DatabaseName);
            _questionCollection = database.GetCollection<Question>(_databaseSettings.QuestionCollectionName);

            _mapper = mapper;
        }

        public async Task CreateQuestionAsync(CreateQuestionDto createQuestionDto)
        {
            var value = _mapper.Map<Question>(createQuestionDto);
            await _questionCollection.InsertOneAsync(value);
        }

        public async Task DeleteQuestionAsync(string id)
        {
            await _questionCollection.DeleteOneAsync(x => x.QuestionId == id);
        }

        public async Task<List<ResultQuestionDto>> GetAllQuestionsAsync()
        {
            var values = await _questionCollection.Find(x => true).ToListAsync();
            return _mapper.Map<List<ResultQuestionDto>>(values);
        }

        public async Task<GetQuestionByIdDto> GetQuestionByIdAsync(string id)
        {
            var value = await _questionCollection.Find(x => x.QuestionId == id).FirstOrDefaultAsync();
            return _mapper.Map<GetQuestionByIdDto>(value);
        }

        public async Task UpdateQuestionAsync(UpdateQuestionDto updateQuestionDto)
        {
            var value = _mapper.Map<Question>(updateQuestionDto);
            await _questionCollection.FindOneAndReplaceAsync(x => x.QuestionId == updateQuestionDto.QuestionId, value);
        }
    }
}
