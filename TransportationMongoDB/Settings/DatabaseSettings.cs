namespace TransportationMongoDB.Settings
{
    public class DatabaseSettings : IDatabaseSettings
    {
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
        public string SliderCollectionName { get; set; }
        public string BrandCollectionName { get; set; }
        public string OfferCollectionName { get; set; }

    }
}
