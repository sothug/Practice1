using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1.Models
{
    public interface IIdentifier
    {
        public ObjectId _id { get; set; }
    }
}
