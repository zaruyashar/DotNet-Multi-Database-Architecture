namespace TransportationMongoDB.Settings
{
    public interface IDatabaseSettings
    {
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
        public string SliderCollectionName { get; set; }
        public string BrandCollectionName { get; set; }
        public string OfferCollectionName { get; set; }
        public string AboutCollectionName { get; set; }
        public string GetInTouchCollectionName { get; set; }
        public string HowItWorkCollectionName { get; set; }
    }
}
