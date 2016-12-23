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
    [BsonDiscriminator("diary")]
    public class Diary
    {
        [JsonIgnore]
        public ObjectId Id { get; set; }

        [BsonElement("name", Order = 1)]
        public string Name { get; set; }

        [BsonElement("description", Order = 2)]
        public string Description { get; set; }

        [BsonElement("macros", Order = 3)]
        public List<string> Macros { get; set; }

        [BsonElement("foodType", Order = 4)]
        public string FoodType { get; set; }

        [BsonElement("dateCreated", Order = 5)]
        public DateTime DateCreated { get; set; }

        [BsonElement("userId", Order = 6)]
        public ObjectId UserId { get; set; }

        [BsonElement("mealId", Order = 7)]
        public ObjectId MealId { get; set; }

        [BsonElement("_mediaItems", Order = 8)]
        public List<ObjectId> MediaItems { get; set; }
    }
}
