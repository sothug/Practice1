// Начисления услуги абоненты
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Practice1.Models
{
    public class Class_PaySumma : IIdentifier
    {
        [BsonId]
        public ObjectId _id { get; set; }

        [BsonElement("Id")]
        public int Id { get; set; }

        [BsonElement("AccountCD")]
        public string AccountCD { get; set; }

        [BsonElement("ServiceCD")]
        public string ServiceCD { get; set; }

        [BsonElement("PaySum")]
        public double PaySum { get; set; }

        [BsonElement("PayDate")]
        public DateTime PayDate { get; set; }

        [BsonElement("PayMonth")]
        public string PayMonth { get; set; }

        [BsonElement("PayYear")]
        public int PayYear { get; set; }
    }
}


