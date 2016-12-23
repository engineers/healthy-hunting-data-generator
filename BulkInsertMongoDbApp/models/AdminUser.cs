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
    [BsonDiscriminator("adminuser")]
    public class AdminUser
    {
        [JsonIgnore]
        public ObjectId Id { get; set; }

        [BsonElement("fullName", Order = 1)]
        public string FullName { get; set; }

        [BsonElement("email", Order = 2)]
        public string Email { get; set; }

        [BsonElement("password", Order = 3)]
        public string Password { get; set; }

        [BsonElement("active", Order = 4)]
        public bool Active { get; set; }

        [BsonElement("system", Order = 5)]
        public bool System { get; set; }

        [BsonElement("dateCreated", Order = 6)]
        public DateTime DateCreated { get; set; }

        [BsonElement("_role", Order = 7)]
        public ObjectId RoleId { get; set; }
    }
}
