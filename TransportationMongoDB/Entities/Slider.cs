using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace TransportationMongoDB.Entities
{
    public class Slider
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string SliderId { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}
