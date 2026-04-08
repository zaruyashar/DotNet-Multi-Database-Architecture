using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace TransportationMongoDB.Entities
{
    public class About
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string AboutId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}
