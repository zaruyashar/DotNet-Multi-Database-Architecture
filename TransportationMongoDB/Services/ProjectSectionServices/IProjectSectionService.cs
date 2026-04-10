using TransportationMongoDB.Dtos.ProjectSectionDtos;

namespace TransportationMongoDB.Services.ProjectSectionServices
{
    public interface IProjectSectionService
    {
        Task<List<ResultProjectSectionDto>> GetAllProjectSectionsAsync();
        Task CreateProjectSectionAsync(CreateProjectSectionDto createProjectSectionDto);
        Task UpdateProjectSectionAsync(UpdateProjectSectionDto updateProjectSectionDto);
        Task<GetProjectSectionByIdDto> GetProjectSectionByIdAsync(string id);
        Task DeleteProjectSectionAsync(string id);
    }
}
