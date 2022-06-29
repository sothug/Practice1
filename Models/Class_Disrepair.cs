// Начисления услуги абоненты
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Practice1.Models
{
    public class Class_Disrepair : IIdentifier
    {
        [BsonId]
        public ObjectId _id { get; set; }

        [BsonElement("Id")]
        public int Id { get; set; }

        [BsonElement("FAILURENM")]
        public string FAILURENM { get; set; }

        public override string ToString()
        {
            return FAILURENM;
        }
    }
}


