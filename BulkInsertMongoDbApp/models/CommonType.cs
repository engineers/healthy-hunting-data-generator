using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace BulkInsertMongoDbApp.Models
{
    public abstract class CommonType
    {
        [JsonIgnore]
        public ObjectId Id { get; set; }

        [BsonElement("name", Order = 1)]
        public string Name { get; set; }

        [BsonElement("active", Order = 2)]
        public bool Active { get; set; }

        [BsonElement("order", Order = 3)]
        public int Order { get; set; }

        [BsonElement("dateCreated", Order = 4)]
        public DateTime DateCreated { get; set; }
    }
}
