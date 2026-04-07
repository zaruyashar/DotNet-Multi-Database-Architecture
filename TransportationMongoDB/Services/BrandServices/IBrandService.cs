using TransportationMongoDB.Dtos.BrandDtos;

namespace TransportationMongoDB.Services.BrandServices
{
    public interface IBrandService
    {
        Task<List<ResultBrandDto>> GetAllBrandsAsync();
        Task CreateBrandAsync(CreateBrandDto createBrandDto);
        Task UpdateBrandAsync(UpdateBrandDto updateBrandDto);
        Task<GetBrandByIdDto> GetBrandByIdAsync(string id);
        Task DeleteBrandAsync(string id);
    }
}
