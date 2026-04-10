using TransportationMongoDB.Dtos.QuestionDtos;

namespace TransportationMongoDB.Services.QuestionServices
{
    public interface IQuestionService
    {
        Task<List<ResultQuestionDto>> GetAllQuestionsAsync();
        Task CreateQuestionAsync(CreateQuestionDto createQuestionDto);
        Task UpdateQuestionAsync(UpdateQuestionDto updateQuestionDto);
        Task<GetQuestionByIdDto> GetQuestionByIdAsync(string id);
        Task DeleteQuestionAsync(string id);
    }
}
