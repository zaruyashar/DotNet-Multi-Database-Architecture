using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace DatabaseMastery.TransportMongoDb.Entities
{
    public class GetInTouch
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string GetInTouchId { get; set; }

        public string BadgeTitle { get; set; }          // Get in touch
        public string MainTitle { get; set; }           
        public string Description { get; set; }         // Paragraf

        public string Feature1Title { get; set; }       // Boost your sale
        public string Feature1Description { get; set; }

        public string Feature2Title { get; set; }       // Introducing New Features
        public string Feature2Description { get; set; }

        public string ImageUrl { get; set; }            // Sağdaki görsel
        public bool Status { get; set; }
    }
}
