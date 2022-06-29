// Начисления услуги абоненты
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Practice1.Models
{
    public class Class_Executor : IIdentifier
    {
        [BsonId]
        public ObjectId _id { get; set; }

        [BsonElement("Id")]
        public int Id { get; set; }

        [BsonElement("Fio")]
        public string Fio { get; set; }

        public override string ToString()
        {
            return Fio;
        }
    }
}


