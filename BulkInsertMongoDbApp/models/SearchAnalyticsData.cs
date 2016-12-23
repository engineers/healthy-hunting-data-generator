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
    [BsonDiscriminator("searchanalyticsdata")]
    public class SearchAnalyticsData
    {
        [JsonIgnore]
        public ObjectId Id { get; set; }

        [BsonElement("foodIntolerances", Order = 1)]
        public  string[] FoodIntolerances { get; set; }

        [BsonElement("mealType", Order = 2)]
        public string MealType { get; set; }

        [BsonElement("macros", Order = 3)]
        public string[] Macros { get; set; }

        [BsonElement("dateCreated", Order = 4)]
        public DateTime DateCreated { get; set; }
    }
}
