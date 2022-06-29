// Начисления услуги абоненты
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using MongoDB.Bson;
using Practice1.Models;

namespace Practice1.Mongo
{
    public class MongoDBConnect
    {
        MongoServerSettings Settings_;
        MongoServer server;
        MongoDatabase Database_;
        public static MongoDBConnect _Obj;
        public static MongoDBConnect GetObject()
        {
            if (_Obj == null)
            {
                _Obj = new MongoDBConnect();
            }
            return _Obj;
        }

        public MongoDBConnect()
        {
            Settings_ = new MongoServerSettings();
            Settings_.Server = new MongoServerAddress("localhost", 27017);
            server = new MongoServer(Settings_);
            Database_ = server.GetDatabase("test");
        }

        public SBindingList<T> Load<T>()
        {
            var name = typeof(T).Name.Split('_')[1];
            var collection = Database_.GetCollection<T>(name);
            SBindingList<T> doclist = new SBindingList<T>();
            foreach (T stat in collection.FindAll())
            {
                doclist.Add(stat);
            }
            return doclist;
        }

        public void Delete<T>(T _Obj) where T : IIdentifier
        {
            var name = typeof(T).Name.Split('_')[1];
            MongoCollection<T> Collection_ = Database_.GetCollection<T>(name);
            IMongoQuery Marker = Query.EQ("_id", _Obj._id);
            Collection_.Remove(Marker);
        }

        public void Filter<T>(T _Obj) where T : IIdentifier
        {
            var name = typeof(T).Name.Split('_')[1];
            MongoCollection<T> Collection_ = Database_.GetCollection<T>(name);
            IMongoQuery Marker = Query.EQ("_id", _Obj._id);
            Collection_.Find(Marker);
        }
        public void Insert<T>(T _Obj) where T : IIdentifier
        {
            var name = typeof(T).Name.Split('_')[1];
            MongoCollection<T> Collection_ = Database_.GetCollection<T>(name);
            BsonDocument Stu_Doc = _Obj.ToBsonDocument();
            Collection_.Insert(Stu_Doc);
        }

        public void Update<T>(T _Obj) where T : IIdentifier
        {
            var name = typeof(T).Name.Split('_')[1];
            MongoCollection<T> Collection_ = Database_.GetCollection<T>(name);
            IMongoQuery Marker = Query.EQ("_id", _Obj._id);
            var properties = typeof(T).GetProperties().Where(x => x.Name != "_id" && x.Name != "Id");
            foreach (var p in properties)
            {
                IMongoUpdate Update_ = MongoDB.Driver.Builders.Update.Set(p.Name, BsonValue.Create(p.GetValue(_Obj)));
                Collection_.Update(Marker, Update_);
            }
        }
    }
}