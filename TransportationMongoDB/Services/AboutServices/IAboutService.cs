using TransportationMongoDB.Dtos.AboutDtos;

namespace TransportationMongoDB.Services.AboutServices
{
    public interface IAboutService
    {
        Task<List<ResultAboutDto>> GetAllAboutsAsync();
        Task CreateAboutAsync(CreateAboutDto createAboutDto);
        Task UpdateAboutAsync(UpdateAboutDto updateAboutDto);
        Task<GetAboutByIdDto> GetAboutByIdAsync(string id);
        Task DeleteAboutAsync(string id);
    }
}
