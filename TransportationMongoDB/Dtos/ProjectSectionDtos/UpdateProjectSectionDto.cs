namespace TransportationMongoDB.Dtos.ProjectSectionDtos
{
    public class UpdateProjectSectionDto
    {
        public string ProjectSectionId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public bool IsStatus { get; set; }
    }
}
