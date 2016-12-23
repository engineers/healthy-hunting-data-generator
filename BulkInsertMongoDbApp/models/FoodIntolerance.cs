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
    [BsonDiscriminator("foodintolerance")]
    public class FoodIntolerance : CommonType
    {
    }
}
