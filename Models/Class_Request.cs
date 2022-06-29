// Начисления услуги абоненты
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Practice1.Models
{
    public class Class_Request : IIdentifier
    {
        [BsonId]
        public ObjectId _id { get; set; }

        [BsonElement("Id")]
        public int Id { get; set; }

        [BsonElement("AccountCD")]
        public string AccountCD { get; set; }

        [BsonElement("ExecutorCD")]
        public string ExecutorCD { get; set; }

        [BsonElement("FailureCD")]
        public string FailureCD { get; set; }

        [BsonElement("IncomingDate")]
        public DateTime IncomingDate { get; set; }

        [BsonElement("ExecutionDate")]
        public DateTime ExecutionDate { get; set; }

        [BsonElement("Executed")]
        public bool Executed { get; set; }
    }
}


