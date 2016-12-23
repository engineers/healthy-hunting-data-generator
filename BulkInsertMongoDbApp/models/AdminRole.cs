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
    [BsonDiscriminator("adminrole")]
    public class AdminRole
    {
        [JsonIgnore]
        public ObjectId Id { get; set; }

        [BsonElement("name", Order = 1)]
        public string Name { get; set; }

        [BsonElement("dateCreated", Order = 2)]
        public DateTime DateCreated { get; set; }
    }
}
