namespace TransportationMongoDB.Settings
{
    public class DatabaseSettings : IDatabaseSettings
    {
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
        public string SliderCollectionName { get; set; }
        public string BrandCollectionName { get; set; }
        public string OfferCollectionName { get; set; }
        public string AboutCollectionName { get; set; }
        public string GetInTouchCollectionName { get; set; }
        public string HowItWorkCollectionName { get; set; }
        public string TestimonialCollectionName { get; set; }
        public string ProjectSectionCollectionName { get; set; }
        public string QuestionCollectionName { get; set; }
        public string ShipmentCollectionName { get; set; }

    }
}
