namespace TransportationMongoDB.Dtos.TestimonialDtos
{
    public class ResultTestimonialDto
    {
        public string TestimonialId { get; set; }
        public string NameSurname { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public string ReviewDetail { get; set; }
        public int ReviewScore { get; set; }
        public bool Status { get; set; }
    }
}
