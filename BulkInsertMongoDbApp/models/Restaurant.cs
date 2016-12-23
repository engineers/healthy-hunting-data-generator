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
    [BsonDiscriminator("restaurant")]
    public class Restaurant
    {
        [JsonIgnore]
        public ObjectId Id { get; set; }

        [BsonElement("name", Order = 1)]
        public string Name { get; set; }

        [BsonElement("address", Order = 2)]
        public string Address { get; set; }

        [BsonElement("location", Order = 3)]
        public GeoLocation Location { get; set; }

        [BsonElement("postalCode", Order = 4)]
        public string PostalCode { get; set; }

        [BsonElement("description", Order = 5)]
        public string Description { get; set; }

        [BsonElement("websiteUrl", Order = 6)]
        public string WebsiteUrl { get; set; }

        [BsonElement("phone", Order = 7)]
        public string Phone { get; set; }

        [BsonElement("email", Order = 8)]
        public string Email { get; set; }

        [BsonElement("contactPerson", Order = 9)]
        public string ContactPerson { get; set; }

        [BsonElement("active", Order = 10)]
        public bool Active { get; set; }

        [BsonElement("dateCreated", Order = 11)]
        public DateTime DateCreated { get; set; }

        [BsonElement("socialLinks", Order = 12)]
        public List<SocialLink> SocialLinks { get; set; }

        [BsonElement("openingTimes", Order = 13)]
        public List<OpeningTime> OpeningTimes { get; set; }

        [BsonElement("_cuisineType", Order = 14)]
        public ObjectId CuisineTypeId { get; set; }

        [BsonElement("meals", Order = 15)]
        public List<Meal> Meals { get; set; }

        [BsonElement("mediaItems", Order = 16)]
        public List<MediaItem> MediaItems { get; set; }

        public class SocialLink
        {
            [BsonElement("socialNetworkType", Order = 1)]
            public string SocialNetworkType { get; set; }

            [BsonElement("url", Order = 2)]
            public string Url { get; set; }
        }

        public class OpeningTime
        {
            [BsonElement("day", Order = 1)]
            public int Day { get; set; }

            [BsonElement("fromHour", Order = 2)]
            public int FromHour { get; set; }

            [BsonElement("fromMinute", Order = 3)]
            public int FromMinute { get; set; }

            [BsonElement("toHour", Order = 4)]
            public int ToHour { get; set; }

            [BsonElement("toMinute", Order = 5)]
            public int ToMinute { get; set; }
        }

        public class GeoLocation
        {
            [BsonElement("type", Order = 1)]
            public string Type { get; set; }

            [BsonElement("coordinates", Order = 2)]
            public double[] Coordinates { get; set; }
        }

        public class Meal
        {
            [BsonElement("_id", Order = 0)]
            public ObjectId Id { get; set; }

            [BsonElement("name", Order = 1)]
            public string Name { get; set; }

            [BsonElement("description", Order = 2)]
            public string Description { get; set; }

            [BsonElement("ingredients ", Order = 3)]
            public string[] Ingredients { get; set; }

            [BsonElement("price", Order = 4)]
            public decimal Price { get; set; }

            [BsonElement("kind", Order = 5)]
            public string Kind { get; set; }

            [BsonElement("active", Order = 6)]
            public bool Active { get; set; }

            [BsonElement("dateCreated", Order = 7)]
            public DateTime DateCreated { get; set; }

            [BsonElement("_type", Order = 8)]
            public ObjectId TypeId { get; set; }

            [BsonElement("_foodIntolerances", Order = 9)]
            public List<ObjectId> FoodIntolerances { get; set; }

            [BsonElement("_macros", Order = 10)]
            public List<ObjectId> Macros { get; set; }

            [BsonElement("mediaItems", Order = 11)]
            public List<MediaItem> MediaItems { get; set; }
        }

        public class MediaItem
        {
            [BsonElement("_id", Order = 0)]
            public ObjectId Id { get; set; }

            [BsonElement("key", Order = 1)]
            public string Key { get; set; }

            [BsonElement("url", Order = 2)]
            public string Url { get; set; }

            [BsonElement("mediaType", Order = 3)]
            public string MediaType { get; set; }

            [BsonElement("default", Order = 4)]
            public bool Default { get; set; }

            [BsonElement("active", Order = 5)]
            public bool Active { get; set; }

            [BsonElement("dateCreated", Order = 6)]
            public DateTime DateCreated { get; set; }
        }
    }
}
