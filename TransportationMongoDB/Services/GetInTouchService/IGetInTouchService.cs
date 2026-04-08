using TransportationMongoDB.Dtos.GetInTouchDtos;

namespace TransportationMongoDB.Services.GetInTouchService
{
    public interface IGetInTouchService
    {
        Task<List<ResultGetInTouchDto>> GetAllGetInTouchsAsync();
        Task CreateGetInTouchAsync(CreateGetInTouchDto createGetInTouchDto);
        Task UpdateGetInTouchAsync(UpdateGetInTouchDto updateGetInTouchDto);
        Task<GetInTouchByIdDto> GetGetInTouchByIdAsync(string id);
        Task DeleteGetInTouchAsync(string id);
    }
}
