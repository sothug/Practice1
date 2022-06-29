// Начисления услуги абоненты
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Practice1.Models
{
    public class Class_NachislSumma : IIdentifier
    {
        [BsonId]
        public ObjectId _id { get; set; }

        [BsonElement("Id")]
        public int Id { get; set; }

        [BsonElement("AccountCD")]
        public string AccountCD { get; set; }

        [BsonElement("ServiceCD")]
        public string ServiceCD { get; set; }

        [BsonElement("NachislSum")]
        public double NachislSum { get; set; }

        [BsonElement("NachislMonth")]
        public string NachislMonth { get; set; }

        [BsonElement("NachislYear")]
        public int NachislYear { get; set; }
    }
}


