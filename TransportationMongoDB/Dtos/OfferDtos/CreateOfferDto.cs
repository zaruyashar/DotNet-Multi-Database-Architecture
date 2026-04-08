namespace TransportationMongoDB.Dtos.OfferDtos
{
    public class CreateOfferDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public bool IsStatus { get; set; }
    }
}
