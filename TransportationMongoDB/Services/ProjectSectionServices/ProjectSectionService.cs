using AutoMapper;
using MongoDB.Driver;
using TransportationMongoDB.Dtos.ProjectSectionDtos;
using TransportationMongoDB.Entities;
using TransportationMongoDB.Settings;

namespace TransportationMongoDB.Services.ProjectSectionServices
{
    public class ProjectSectionService : IProjectSectionService
    {
        private readonly IMongoCollection<ProjectSection> _projectSectionCollection;
        private readonly IMapper _mapper;

        public ProjectSectionService(IMapper mapper, IDatabaseSettings _databaseSettings)
        {
            var client = new MongoClient(_databaseSettings.ConnectionString);
            var database = client.GetDatabase(_databaseSettings.DatabaseName);
            _projectSectionCollection = database.GetCollection<ProjectSection>(_databaseSettings.ProjectSectionCollectionName);

            _mapper = mapper;
        }

        public async Task CreateProjectSectionAsync(CreateProjectSectionDto createProjectSectionDto)
        {
            var value = _mapper.Map<ProjectSection>(createProjectSectionDto);
            await _projectSectionCollection.InsertOneAsync(value);
        }

        public async Task DeleteProjectSectionAsync(string id)
        {
            await _projectSectionCollection.DeleteOneAsync(x => x.ProjectSectionId == id);
        }

        public async Task<List<ResultProjectSectionDto>> GetAllProjectSectionsAsync()
        {
            var values = await _projectSectionCollection.Find(x => true).ToListAsync();
            return _mapper.Map<List<ResultProjectSectionDto>>(values);
        }

        public async Task<GetProjectSectionByIdDto> GetProjectSectionByIdAsync(string id)
        {
            var value = await _projectSectionCollection.Find(x => x.ProjectSectionId == id).FirstOrDefaultAsync();
            return _mapper.Map<GetProjectSectionByIdDto>(value);
        }

        public async Task UpdateProjectSectionAsync(UpdateProjectSectionDto updateProjectSectionDto)
        {
            var value = _mapper.Map<ProjectSection>(updateProjectSectionDto);
            await _projectSectionCollection.FindOneAndReplaceAsync(x => x.ProjectSectionId == updateProjectSectionDto.ProjectSectionId, value);
        }
    }
}
