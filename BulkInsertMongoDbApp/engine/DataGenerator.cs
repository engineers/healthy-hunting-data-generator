using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using BulkInsertMongoDbApp.Models;
using MongoDB.Bson;
using MongoDB.Driver;

namespace BulkInsertMongoDbApp.Engine
{
    public static class DataGenerator
    {
        public static bool InsertGeneratedData(RichTextBox richTextBox, int numOfUsers, int numOfRestaurant, int maxNumOfMealsPerRestaurant, int numOfSearchAnalyticsData)
        {
            //MongoUrl url = new MongoUrl("mongodb://localhost:27017");
            MongoUrl url = new MongoUrl("mongodb://localhost:27017");
            MongoClient client = new MongoClient(url);
            //MongoClient client = new MongoClient();
            var db = client.GetDatabase("healthyhuntingdb");

            richTextBox.AppendText("----- Start Generating Data... -----");

            var adminrole = db.GetCollection<AdminRole>("adminrole");
            var adminRoles = GenerateAdminRoleData();
            adminrole.InsertMany(adminRoles);
            richTextBox.AppendText(Environment.NewLine + "Admin Roles Inserted: " + adminRoles.Count);

            var adminuser = db.GetCollection<AdminUser>("adminuser");
            var adminUsers = GenerateAdminUserData(adminrole);
            adminuser.InsertMany(adminUsers);
            richTextBox.AppendText(Environment.NewLine + "Admin Users Inserted: " + adminUsers.Count);

            var foodintolerance = db.GetCollection<FoodIntolerance>("foodintolerance");
            var foodIntolerances = GenerateFoodIntoleranceData();
            foodintolerance.InsertMany(foodIntolerances);
            richTextBox.AppendText(Environment.NewLine + "Food Intolerances Inserted: " + foodIntolerances.Count);

            var user = db.GetCollection<User>("user");
            var users = GenerateUserData(numOfUsers, foodintolerance);
            user.InsertMany(users);
            richTextBox.AppendText(Environment.NewLine + "Users Inserted: " + users.Count);

            var mealtype = db.GetCollection<MealType>("mealtype");
            var mealTypes = GenerateMealTypeData();
            mealtype.InsertMany(mealTypes);
            richTextBox.AppendText(Environment.NewLine + "Meal Types Inserted: " + mealTypes.Count);

            var cuisinetype = db.GetCollection<CuisineType>("cuisinetype");
            var cuisineTypes = GenerateCuisineTypeData();
            cuisinetype.InsertMany(cuisineTypes);
            richTextBox.AppendText(Environment.NewLine + "Cuisine Types Inserted: " + cuisineTypes.Count);

            var macro = db.GetCollection<Macro>("macro");
            var macros = GenerateMacroData();
            macro.InsertMany(macros);
            richTextBox.AppendText(Environment.NewLine + "Macros Inserted: " + macros.Count);

            var restaurant = db.GetCollection<Restaurant>("restaurant");
            var restaurants = GenerateRestaurantsData(numOfRestaurant, maxNumOfMealsPerRestaurant, cuisinetype, mealtype, foodintolerance, macro);
            restaurant.InsertMany(restaurants);
            richTextBox.AppendText(Environment.NewLine + "Restaurants Inserted: " + restaurants.Count);

            var searchanalyticsdata = db.GetCollection<SearchAnalyticsData>("searchanalyticsdata");
            var searchAnalytics = GenerateSearchAnalyticsData(numOfSearchAnalyticsData, mealtype, foodintolerance, macro);
            searchanalyticsdata.InsertMany(searchAnalytics);
            richTextBox.AppendText(Environment.NewLine + "Search Analytics Data Inserted: " + searchAnalytics.Count);

            var question = db.GetCollection<Question>("question");
            var questions = GenerateQuestionData();
            question.InsertMany(questions);
            richTextBox.AppendText(Environment.NewLine + "Questions Inserted: " + questions.Count);

            richTextBox.AppendText(Environment.NewLine + "----- Generating Data Finished. -----");

            return true;
        }

        private static List<AdminRole> GenerateAdminRoleData()
        {
            List<AdminRole> list = new List<AdminRole>();

            AdminRole item;

            item = new AdminRole()
            {
                Name = "Administrator",
                DateCreated = DateTime.Now
            };
            list.Add(item);

            return list;
        }

        private static List<AdminUser> GenerateAdminUserData(IMongoCollection<AdminRole> adminRoleCollection)
        {
            List<AdminUser> list = new List<AdminUser>();

            AdminUser item;

            ObjectId adminRoleId = adminRoleCollection.AsQueryable().First(x => x.Name == "Administrator").Id;

            item = new AdminUser()
            {
                FullName = "Administrator",
                Email = "admin@test.te",
                Password = "$2a$10$qJ0DfSozGQPW/..W1oC/9e4jj2BbLbRcXl2Hs9m53ghuLdgWRfsH.", //admin
                Active = true,
                System = true,
                DateCreated = DateTime.Now,
                RoleId = adminRoleId
            };
            list.Add(item);

            item = new AdminUser()
            {
                FullName = "Admin User 1",
                Email = "admin1@test.te",
                Password = "$2a$10$qJ0DfSozGQPW/..W1oC/9e4jj2BbLbRcXl2Hs9m53ghuLdgWRfsH.",
                Active = true,
                System = false,
                DateCreated = DateTime.Now,
                RoleId = adminRoleId
            };
            list.Add(item);

            item = new AdminUser()
            {
                FullName = "Admin User 2",
                Email = "admin2@test.te",
                Password = "$2a$10$qJ0DfSozGQPW/..W1oC/9e4jj2BbLbRcXl2Hs9m53ghuLdgWRfsH.",
                Active = true,
                System = false,
                DateCreated = DateTime.Now,
                RoleId = adminRoleId
            };
            list.Add(item);

            item = new AdminUser()
            {
                FullName = "Admin User 3",
                Email = "admin3@test.te",
                Password = "$2a$10$qJ0DfSozGQPW/..W1oC/9e4jj2BbLbRcXl2Hs9m53ghuLdgWRfsH.",
                Active = true,
                System = false,
                DateCreated = DateTime.Now,
                RoleId = adminRoleId
            };
            list.Add(item);

            item = new AdminUser()
            {
                FullName = "Admin User 4",
                Email = "admin4@test.te",
                Password = "$2a$10$qJ0DfSozGQPW/..W1oC/9e4jj2BbLbRcXl2Hs9m53ghuLdgWRfsH.",
                Active = true,
                System = false,
                DateCreated = DateTime.Now,
                RoleId = adminRoleId
            };
            list.Add(item);

            item = new AdminUser()
            {
                FullName = "Admin User 5",
                Email = "admin5@test.te",
                Password = "$2a$10$qJ0DfSozGQPW/..W1oC/9e4jj2BbLbRcXl2Hs9m53ghuLdgWRfsH.",
                Active = true,
                System = false,
                DateCreated = DateTime.Now,
                RoleId = adminRoleId
            };
            list.Add(item);

            return list;
        }

        private static List<FoodIntolerance> GenerateFoodIntoleranceData()
        {
            List<FoodIntolerance> list = new List<FoodIntolerance>();

            int cnt = 0;
            FoodIntolerance foodIntolerance;

            foodIntolerance = new FoodIntolerance()
            {
                Name = "Wheat Free",
                Active = true,
                Order = cnt++,
                DateCreated = DateTime.Now
            };
            list.Add(foodIntolerance);

            foodIntolerance = new FoodIntolerance()
            {
                Name = "Gluten Free",
                Active = true,
                Order = cnt++,
                DateCreated = DateTime.Now
            };
            list.Add(foodIntolerance);

            foodIntolerance = new FoodIntolerance()
            {
                Name = "Dairy Free",
                Active = true,
                Order = cnt++,
                DateCreated = DateTime.Now
            };
            list.Add(foodIntolerance);

            foodIntolerance = new FoodIntolerance()
            {
                Name = "Shelfish Free",
                Active = true,
                Order = cnt++,
                DateCreated = DateTime.Now
            };
            list.Add(foodIntolerance);

            foodIntolerance = new FoodIntolerance()
            {
                Name = "Nut Free",
                Active = true,
                Order = cnt++,
                DateCreated = DateTime.Now
            };
            list.Add(foodIntolerance);

            foodIntolerance = new FoodIntolerance()
            {
                Name = "Soy Free",
                Active = true,
                Order = cnt++,
                DateCreated = DateTime.Now
            };
            list.Add(foodIntolerance);

            foodIntolerance = new FoodIntolerance()
            {
                Name = "Sugar Free",
                Active = true,
                Order = cnt++,
                DateCreated = DateTime.Now
            };
            list.Add(foodIntolerance);

            foodIntolerance = new FoodIntolerance()
            {
                Name = "Vegetarian",
                Active = true,
                Order = cnt++,
                DateCreated = DateTime.Now
            };
            list.Add(foodIntolerance);

            foodIntolerance = new FoodIntolerance()
            {
                Name = "Vegan",
                Active = true,
                Order = cnt++,
                DateCreated = DateTime.Now
            };
            list.Add(foodIntolerance);

            foodIntolerance = new FoodIntolerance()
            {
                Name = "Pesticitarian",
                Active = true,
                Order = cnt++,
                DateCreated = DateTime.Now
            };
            list.Add(foodIntolerance);

            return list;
        }

        private static List<User> GenerateUserData(int size, IMongoCollection<FoodIntolerance> foodIntoleranceCollection)
        {
            List<User> list = new List<User>();

            User item;
            Random rand = new Random();

            for (var i = 0; i <= size; i++)
            {
                List<ObjectId> foodIntoleranceRefs = new List<ObjectId>();

                for (var j = 0; j < rand.Next(foodIntoleranceCollection.AsQueryable().Count()); j++)
                {
                    var foodIntoleranceId = RandomFoodIntoleranceId(rand, foodIntoleranceCollection);
                    if (!foodIntoleranceRefs.Contains(foodIntoleranceId))
                        foodIntoleranceRefs.Add(foodIntoleranceId);
                }

                item = new User()
                {
                    FullName = "Test Testerson " + i,
                    Email = "test" + i + "@test.te",
                    Password = "$2a$10$Xh3Sjsf/PKoj8XpjYNb9IuKuCilWiQsMASsf9SDR0uKF9c9evmdiq",
                    Phone = "+44 113 245 3097",
                    BirthDate = GetRandomDate(rand, new DateTime(1950,1,1), new DateTime(2003, 1, 1)),
                    Gender = rand.Next(1) > 0 ? "M" : "F",
                    HomeAddress = new User.AddressData()
                    {
                        Address = i + ", Generic street, Leeds, United Kingdom",
                        Latitude = RandomLeedsLatitude(rand),
                        Longitude = RandomLeedsLongitude(rand),
                        PostalCode = "LS10 1JQ",
                    },
                    WorkAddress = new User.AddressData()
                    {
                        Address = i + ", Working street, Leeds, United Kingdom",
                        Latitude = RandomLeedsLatitude(rand),
                        Longitude = RandomLeedsLongitude(rand),
                        PostalCode = "LS10 1JQ",
                    },
                    OtherAddress = new User.AddressData()
                    {
                        Address = i + ", Other street, Leeds, United Kingdom",
                        Latitude = RandomLeedsLatitude(rand),
                        Longitude = RandomLeedsLongitude(rand),
                        PostalCode = "LS10 1JQ",
                    },
                    FacebookId = "625583364264607",
                    FacebookToken = "EAAHHMZCZAV6c0BANFPxgeriCE37zKYDgUBaDRrhvZCTeQ09ROdcUyjo85v4jc2Idj9wugFs9a5VFWdvoqKztHqKritoMdpp7vtxkZCjn5cHQiAYEAGw7EIuKgkgBHol5uFYIBgvaDhV4IgfhFcC72AvDqw5RTaLQnarVhFWMfTPRPOJNaIi4",
                    FacebookTokenExpDate = DateTime.Now.AddDays(30),
                    Code = null,
                    Active = true,
                    DateCreated = DateTime.Now,
                    FoodIntolerances = foodIntoleranceRefs
                };
                list.Add(item);
            }
            return list;
        }

        private static List<MealType> GenerateMealTypeData()
        {
            List<MealType> list = new List<MealType>();

            int cnt = 0;
            MealType mealType;

            mealType = new MealType()
            {
                Name = "Breakfast",
                Active = true,
                Order = cnt++,
                DateCreated = DateTime.Now
            };
            list.Add(mealType);

            mealType = new MealType()
            {
                Name = "Lunch",
                Active = true,
                Order = cnt++,
                DateCreated = DateTime.Now
            };
            list.Add(mealType);

            mealType = new MealType()
            {
                Name = "Dinner",
                Active = true,
                Order = cnt++,
                DateCreated = DateTime.Now
            };
            list.Add(mealType);

            mealType = new MealType()
            {
                Name = "Drink",
                Active = true,
                Order = cnt++,
                DateCreated = DateTime.Now
            };
            list.Add(mealType);

            mealType = new MealType()
            {
                Name = "Snack",
                Active = true,
                Order = cnt++,
                DateCreated = DateTime.Now
            };
            list.Add(mealType);

            return list;
        }

        private static List<Question> GenerateQuestionData()
        {
            List<Question> list = new List<Question>();

            int cnt = 0;
            Question question;

            question = new Question()
            {
                Text = "How do you keep fit?",
                Order = cnt++
            };
            list.Add(question);

            question = new Question()
            {
                Text = "Whats your opinion on meditation?",
                Order = cnt++
            };
            list.Add(question);

            question = new Question()
            {
                Text = "Whats your all time favourite food to eat?",
                Order = cnt++
            };
            list.Add(question);

            return list;
        }
        private static List<CuisineType> GenerateCuisineTypeData()
        {
            List<CuisineType> list = new List<CuisineType>();

            int cnt = 0;
            CuisineType cuisineType;

            cuisineType = new CuisineType()
            {
                Name = "Juice Bar",
                Active = true,
                Order = cnt++,
                DateCreated = DateTime.Now
            };
            list.Add(cuisineType);

            cuisineType = new CuisineType()
            {
                Name = "Healthy Eatery",
                Active = true,
                Order = cnt++,
                DateCreated = DateTime.Now
            };
            list.Add(cuisineType);

            cuisineType = new CuisineType()
            {
                Name = "British",
                Active = true,
                Order = cnt++,
                DateCreated = DateTime.Now
            };
            list.Add(cuisineType);

            cuisineType = new CuisineType()
            {
                Name = "Caribbean",
                Active = true,
                Order = cnt++,
                DateCreated = DateTime.Now
            };
            list.Add(cuisineType);

            cuisineType = new CuisineType()
            {
                Name = "Chinese",
                Active = true,
                Order = cnt++,
                DateCreated = DateTime.Now
            };
            list.Add(cuisineType);

            cuisineType = new CuisineType()
            {
                Name = "Desserts",
                Active = true,
                Order = cnt++,
                DateCreated = DateTime.Now
            };
            list.Add(cuisineType);

            cuisineType = new CuisineType()
            {
                Name = "European",
                Active = true,
                Order = cnt++,
                DateCreated = DateTime.Now
            };
            list.Add(cuisineType);

            cuisineType = new CuisineType()
            {
                Name = "Indian",
                Active = true,
                Order = cnt++,
                DateCreated = DateTime.Now
            };
            list.Add(cuisineType);

            cuisineType = new CuisineType()
            {
                Name = "Italian",
                Active = true,
                Order = cnt++,
                DateCreated = DateTime.Now
            };
            list.Add(cuisineType);

            cuisineType = new CuisineType()
            {
                Name = "Japanese",
                Active = true,
                Order = cnt++,
                DateCreated = DateTime.Now
            };

            cuisineType = new CuisineType()
            {
                Name = "Mexican",
                Active = true,
                Order = cnt++,
                DateCreated = DateTime.Now
            };

            cuisineType = new CuisineType()
            {
                Name = "Middle Eastern",
                Active = true,
                Order = cnt++,
                DateCreated = DateTime.Now
            };

            cuisineType = new CuisineType()
            {
                Name = "Sandwiches & Salads",
                Active = true,
                Order = cnt++,
                DateCreated = DateTime.Now
            };
            cuisineType = new CuisineType()
            {
                Name = "Vietnamese",
                Active = true,
                Order = cnt++,
                DateCreated = DateTime.Now
            };
            list.Add(cuisineType);

            return list;
        }

        private static List<Macro> GenerateMacroData()
        {
            List<Macro> list = new List<Macro>();

            int cnt = 0;
            Macro macro;

            macro = new Macro()
            {
                Name = "High in protein 8g",
                Active = true,
                Order = cnt++,
                DateCreated = DateTime.Now
            };
            list.Add(macro);

            macro = new Macro()
            {
                Name = "High in protein 18g",
                Active = true,
                Order = cnt++,
                DateCreated = DateTime.Now
            };
            list.Add(macro);

            macro = new Macro()
            {
                Name = "High in protein 25g",
                Active = true,
                Order = cnt++,
                DateCreated = DateTime.Now
            };
            list.Add(macro);

            macro = new Macro()
            {
                Name = "Calorie Conscious 200g",
                Active = true,
                Order = cnt++,
                DateCreated = DateTime.Now
            };
            list.Add(macro);

            macro = new Macro()
            {
                Name = "Calorie Conscious 350g",
                Active = true,
                Order = cnt++,
                DateCreated = DateTime.Now
            };
            list.Add(macro);

            macro = new Macro()
            {
                Name = "Calorie Conscious 500g",
                Active = true,
                Order = cnt++,
                DateCreated = DateTime.Now
            };
            list.Add(macro);

            macro = new Macro()
            {
                Name = "Energy boosting",
                Active = true,
                Order = cnt++,
                DateCreated = DateTime.Now
            };
            list.Add(macro);

            macro = new Macro()
            {
                Name = "Low carbs",
                Active = true,
                Order = cnt++,
                DateCreated = DateTime.Now
            };
            list.Add(macro);

            macro = new Macro()
            {
                Name = "Low fat",
                Active = true,
                Order = cnt++,
                DateCreated = DateTime.Now
            };
            list.Add(macro);

            macro = new Macro()
            {
                Name = "Full of vitamins",
                Active = true,
                Order = cnt++,
                DateCreated = DateTime.Now
            };
            list.Add(macro);

            macro = new Macro()
            {
                Name = "Plant Based",
                Active = true,
                Order = cnt++,
                DateCreated = DateTime.Now
            };
            list.Add(macro);

            macro = new Macro()
            {
                Name = "No added sugar",
                Active = true,
                Order = cnt++,
                DateCreated = DateTime.Now
            };
            list.Add(macro);

            return list;
        }

        private static List<Restaurant.Meal> GenerateMealsData(int size, Random rand, IMongoCollection<MealType> mealTypeCollection, IMongoCollection<FoodIntolerance> foodIntoleranceCollection, IMongoCollection<Macro> macroCollection)
        {
            List<Restaurant.Meal> list = new List<Restaurant.Meal>();
            Restaurant.Meal meal;

            for (var i = 0; i <= rand.Next(size); i++)
            {
                List<ObjectId> foodIntoleranceRefs = new List<ObjectId>();

                for (var j = 0; j < rand.Next(foodIntoleranceCollection.AsQueryable().Count()); j++)
                {
                    var foodIntoleranceId = RandomFoodIntoleranceId(rand, foodIntoleranceCollection);
                    if (!foodIntoleranceRefs.Contains(foodIntoleranceId))
                        foodIntoleranceRefs.Add(foodIntoleranceId);
                }

                List<ObjectId> macrosRefs = new List<ObjectId>();

                for (var j = 0; j < rand.Next(macroCollection.AsQueryable().Count()); j++)
                {
                    var macroId = RandomMacroId(rand, macroCollection);
                    if (!macrosRefs.Contains(macroId))
                        macrosRefs.Add(macroId);
                }

                meal = new Restaurant.Meal()
                {   
                    Id = ObjectId.GenerateNewId(),
                    Name = "Meal " + i,
                    Description = "Description for meal " + i,
                    Macros = macrosRefs,
                    Price = RandomMenuItemPrice(rand),
                    Kind = "Kind " + i,
                    Active = true,
                    DateCreated = DateTime.Now,
                    TypeId = RandomMealTypeId(rand, mealTypeCollection),
                    FoodIntolerances = foodIntoleranceRefs,
                    MediaItems = new List<Restaurant.MediaItem>()
                    {
                        new Restaurant.MediaItem()
                        {
                            Id = ObjectId.GenerateNewId(),
                            Key = "testmeal",
                            Url = "https://healthy-hunting-images-upload.s3.amazonaws.com/testmeal",
                            MediaType = "Image",
                            Default = true,
                            Active = true,
                            DateCreated = DateTime.Now
                        }
                    }
                };

                list.Add(meal);
            }

            return list;
        }

        private static List<Restaurant> GenerateRestaurantsData(int size, int maxMenuSize, IMongoCollection<CuisineType> cuisineTypeCollection, IMongoCollection<MealType> mealTypeCollection, IMongoCollection<FoodIntolerance> foodIntoleranceCollection, IMongoCollection<Macro> macroCollection)
        {
            List<Restaurant> list = new List<Restaurant>();
            Restaurant item;
            Random rand = new Random();

            for (var i=0; i <= size; i++)
            {
                List<Restaurant.Meal> meals = GenerateMealsData(maxMenuSize, rand, mealTypeCollection, foodIntoleranceCollection, macroCollection);

                int workingFromHour = 8 + rand.Next(2);
                int workingToHour = 19 + rand.Next(2);
                int sundayFromHour = 10 + rand.Next(3);
                int sundayToHour = 18 + rand.Next(2);

                item = new Restaurant()
                {
                    Name = "Restaurant N# " + i,
                    Address = i + ", Generic street, Leeds, United Kingdom",
                    Location = new Restaurant.GeoLocation()
                    {
                        Type = "Point",
                        Coordinates = new double[2] { RandomLeedsLongitude(rand), RandomLeedsLatitude(rand) }
                    },
                    PostalCode = "LS10 1JQ",
                    Description = "Description from Restaurant N# " + i,
                    WebsiteUrl = "http://www.num" + i + "leeds.uk",
                    Phone = "+44 555 545 6375",
                    Email = "office@num" + i + "leeds.uk",
                    ContactPerson = "John Doe " + i,
                    Active = true,
                    DateCreated = DateTime.Now,
                    SocialLinks = new List<Restaurant.SocialLink>()
                {
                    new Restaurant.SocialLink() { SocialNetworkType = "Facebook", Url = "https://num" + i + "leeds.faceebook.com" },
                    new Restaurant.SocialLink() { SocialNetworkType = "Google+", Url = "https://num" + i + "leeds.google.com" },
                    new Restaurant.SocialLink() { SocialNetworkType = "Twitter", Url = "https://twitter.com/num" + i + "leeds" }
                },
                    OpeningTimes = new List<Restaurant.OpeningTime>()
                {
                    new Restaurant.OpeningTime() { Day = 1, FromHour = workingFromHour, FromMinute = 0, ToHour = workingToHour, ToMinute = 0},
                    new Restaurant.OpeningTime() { Day = 2, FromHour = workingFromHour, FromMinute = 0, ToHour = workingToHour, ToMinute = 0},
                    new Restaurant.OpeningTime() { Day = 3, FromHour = workingFromHour, FromMinute = 0, ToHour = workingToHour, ToMinute = 0},
                    new Restaurant.OpeningTime() { Day = 4, FromHour = workingFromHour, FromMinute = 0, ToHour = workingToHour, ToMinute = 0},
                    new Restaurant.OpeningTime() { Day = 5, FromHour = workingFromHour, FromMinute = 0, ToHour = workingToHour, ToMinute = 0},
                    new Restaurant.OpeningTime() { Day = 6, FromHour = workingFromHour, FromMinute = 0, ToHour = workingToHour, ToMinute = 0},
                    new Restaurant.OpeningTime() { Day = 7, FromHour = sundayFromHour, FromMinute = 0, ToHour = sundayToHour, ToMinute = rand.Next(1) > 0 ? 0 : 30}
                },
                    CuisineTypeId = RandomCuisineTypeId(rand, cuisineTypeCollection),
                    Meals = meals,
                    MediaItems = new List<Restaurant.MediaItem>()
                    {
                        new Restaurant.MediaItem()
                        {
                            Id = ObjectId.GenerateNewId(),
                            Key = "test",
                            Url = "https://healthy-hunting-images-upload.s3.amazonaws.com/test",
                            MediaType = "Image",
                            Default = true,
                            Active = true,
                            DateCreated = DateTime.Now
                        }
                    }
                };
                list.Add(item);
            }

            return list;
        }

        private static List<SearchAnalyticsData> GenerateSearchAnalyticsData(int size, IMongoCollection<MealType> mealTypeCollection, IMongoCollection<FoodIntolerance> foodIntoleranceCollection, IMongoCollection<Macro> macroCollection)
        {
            List<SearchAnalyticsData> list = new List<SearchAnalyticsData>();
            SearchAnalyticsData searchAnalyticsData;
            Random rand = new Random();

            for (var i = 0; i <= size; i++)
            {
                List<string> foodIntoleranceRefs = new List<string>();

                for (var j = 0; j < rand.Next(foodIntoleranceCollection.AsQueryable().Count()); j++)
                {
                    var foodIntoleranceId = RandomFoodIntoleranceId(rand, foodIntoleranceCollection);
                    if (!foodIntoleranceRefs.Contains(foodIntoleranceId.ToString()))
                        foodIntoleranceRefs.Add(foodIntoleranceId.ToString());
                }

                List<string> macrosRefs = new List<string>();

                for (var j = 0; j < rand.Next(macroCollection.AsQueryable().Count()); j++)
                {
                    var macroId = RandomMacroId(rand, macroCollection);
                    if (!macrosRefs.Contains(macroId.ToString()))
                        macrosRefs.Add(macroId.ToString());
                }

                searchAnalyticsData = new SearchAnalyticsData()
                {
                    Id = ObjectId.GenerateNewId(),
                    FoodIntolerances = foodIntoleranceRefs.ToArray(),
                    MealType = RandomMealTypeId(rand, mealTypeCollection).ToString(),
                    Macros = macrosRefs.ToArray(),
                    DateCreated = GetRandomDate(rand, new DateTime(2015, 1, 1), new DateTime(2017, 1, 1))
                };

                list.Add(searchAnalyticsData);
            }

            return list;
        }

        public static DateTime GetRandomDate(Random rand ,DateTime from, DateTime to)
        {
            var range = to - from;

            var randTimeSpan = new TimeSpan((long)(rand.NextDouble() * range.Ticks));

            return from + randTimeSpan;
        }

        public static decimal RandomMenuItemPrice(Random rand)
        {
            double end = 70;
            double start = 2;
            return Convert.ToDecimal(Math.Round((rand.NextDouble() * Math.Abs(end - start)) + start, 2));
        }

        public static ObjectId RandomMealTypeId(Random rand, IMongoCollection<MealType> mealTypeCollection)
        {
            return mealTypeCollection.AsQueryable().ToList().ElementAt(rand.Next(mealTypeCollection.AsQueryable().Count())).Id;
        }

        public static ObjectId RandomFoodIntoleranceId(Random rand, IMongoCollection<FoodIntolerance> foodIntoleranceCollection)
        {
            return foodIntoleranceCollection.AsQueryable().ToList().ElementAt(rand.Next(foodIntoleranceCollection.AsQueryable().Count())).Id;
        }

        public static ObjectId RandomMacroId(Random rand, IMongoCollection<Macro> macroCollection)
        {
            return macroCollection.AsQueryable().ToList().ElementAt(rand.Next(macroCollection.AsQueryable().Count())).Id;
        }
        
        public static double RandomLeedsLatitude(Random rand)
        {
            double end = 53.813071;
            double start = 53.784824;
            return Math.Round((rand.NextDouble() * Math.Abs(end - start)) + start, 6);
        }

        public static double RandomLeedsLongitude(Random rand)
        {
            double end = -1.501904;
            double start = -1.577829;
            return Math.Round((rand.NextDouble() * Math.Abs(end - start)) + start, 6);
        }

        public static ObjectId RandomCuisineTypeId(Random rand, IMongoCollection<CuisineType> cuisineTypeCollection)
        {
            return cuisineTypeCollection.AsQueryable().ToList().ElementAt(rand.Next(cuisineTypeCollection.AsQueryable().Count())).Id;
        }
    }
}
