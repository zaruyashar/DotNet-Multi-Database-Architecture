namespace TransportationMongoDB.Dtos.QuestionDtos
{
    public class UpdateQuestionDto
    {
        public string QuestionId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
    }
}
