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
    [BsonDiscriminator("user")]
    public class User
    {
        [JsonIgnore]
        public ObjectId Id { get; set; }

        [BsonElement("fullName", Order = 1)]
        public string FullName { get; set; }

        [BsonElement("email", Order = 2)]
        public string Email { get; set; }

        [BsonElement("password", Order = 3)]
        public string Password { get; set; }

        [BsonElement("phone", Order = 4)]
        public string Phone { get; set; }

        [BsonElement("birthDate", Order = 5)]
        public DateTime BirthDate { get; set; }

        [BsonElement("gender", Order = 6)]
        public string Gender { get; set; }

        [BsonElement("homeAddress", Order = 7)]
        public AddressData HomeAddress { get; set; }

        [BsonElement("workAddress", Order = 8)]
        public AddressData WorkAddress { get; set; }

        [BsonElement("otherAddress", Order = 9)]
        public AddressData OtherAddress { get; set; }

        [BsonElement("facebookId", Order = 10)]
        public string FacebookId { get; set; }

        [BsonElement("facebookToken", Order = 11)]
        public string FacebookToken { get; set; }

        [BsonElement("facebookTokenExpDate", Order = 12)]
        public DateTime FacebookTokenExpDate { get; set; }

        [BsonElement("code", Order = 13)]
        public string Code { get; set; }

        [BsonElement("active", Order = 14)]
        public bool Active { get; set; }

        [BsonElement("dateCreated", Order = 15)]
        public DateTime DateCreated { get; set; }

        [BsonElement("_foodIntolerances", Order = 16)]
        public List<ObjectId> FoodIntolerances { get; set; }

        public class AddressData
        {
            [BsonElement("address", Order = 1)]
            public string Address { get; set; }

            [BsonElement("latitude", Order = 2)]
            public double Latitude { get; set; }

            [BsonElement("longitude", Order = 3)]
            public double Longitude { get; set; }

            [BsonElement("postalCode", Order = 4)]
            public string PostalCode { get; set; }
        }
    }
}
