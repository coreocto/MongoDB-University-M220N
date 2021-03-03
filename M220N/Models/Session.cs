using MongoDB.Bson.Serialization.Attributes;

namespace M220N.Models
{
    [BsonIgnoreExtraElements]
    public class Session
    {
        
        [BsonElement("user_id")]
        public string UserId { get; set; }

        public string Jwt { get; set; }
    }
}
