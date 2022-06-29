// Начисления услуги абоненты
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Practice1.Models
{
    public class Class_Abonent : IIdentifier
    {
        [BsonId]
        public ObjectId _id { get; set; }

        [BsonElement("Id")]
        public string Id { get; set; }

        [BsonElement("StreetCD")]
        public string StreetCD { get; set; }

        [BsonElement("HouseNo")]
        public int HouseNo { get; set; }

        [BsonElement("FlatNo")]
        public int FlatNo { get; set; }

        [BsonElement("Fio")]
        public string Fio { get; set; }

        [BsonElement("Phone")]
        public string Phone { get; set; }
    }
}


