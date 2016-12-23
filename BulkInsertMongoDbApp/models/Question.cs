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
    [BsonDiscriminator("question")]
    public class Question
    {
        [JsonIgnore]
        public ObjectId Id { get; set; }

        [BsonElement("text", Order = 1)]
        public string Text { get; set; }

        [BsonElement("order", Order = 2)]
        public int Order { get; set; }
    }
}