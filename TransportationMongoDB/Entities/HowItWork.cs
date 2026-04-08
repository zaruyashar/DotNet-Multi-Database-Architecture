using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace TransportationMongoDB.Entities
{
    public class HowItWork
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string HowItWorkId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string IconUrl { get; set; }
        public bool Status { get; set; }
    }
}
