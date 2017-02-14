using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BulkInsertMongoDbApp.Engine;
using BulkInsertMongoDbApp.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using Newtonsoft.Json;

namespace BulkInsertMongoDbApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MongoUrl url = new MongoUrl("mongodb://localhost:27017");
            //MongoClient client = new MongoClient(url);
            //var db = client.GetDatabase("healthyhuntingdb");
            //var collection = db.GetCollection<FoodIntolerance>("foodintolerance");
            //List<FoodIntolerance> foodIntolerances = collection.AsQueryable().ToList();

            //string jsonFoodIntolerances = JsonConvert.SerializeObject(foodIntolerances);

            //collection.InsertOne(new FoodIntolerance()
            //{
            //    Name = "Test",
            //    Active = true,
            //    Order = 43,
            //    DateCreated = DateTime.UtcNow
            //});

            //MongoUrl url = new MongoUrl("mongodb://localhost:27017");
            MongoUrl url = new MongoUrl("mongodb://localhost:27017");
            MongoClient client = new MongoClient(url);
            //MongoClient client = new MongoClient();
            var db = client.GetDatabase("healthyhuntingdb");

            var diary = db.GetCollection<Diary>("diary");
            var diaries = GenerateDiaryData();
            diary.InsertMany(diaries);
        }

        private static List<Diary> GenerateDiaryData()
        {
            List<Diary> list = new List<Diary>();

            Diary item;

            ObjectId userId = new ObjectId("57fce001b080a4c016c0aa2c");

            item = new Diary()
            {
                Name = "Diary 1",
                Description = "Diary desc 1",
                Macros = new List<string>(),
                FoodType = "Type 1",
                DateCreated = DateTime.Now,
                UserId = userId
            };
            list.Add(item);

            item = new Diary()
            {
                Name = "Diary 2",
                Description = "Diary desc 2",
                Macros = new List<string>(),
                FoodType = "Type 2",
                DateCreated = DateTime.Now,
                UserId = userId
            };
            list.Add(item);

            item = new Diary()
            {
                Name = "Diary 3",
                Description = "Diary desc 3",
                Macros = new List<string>(),
                FoodType = "Type 3",
                DateCreated = DateTime.Now,
                UserId = userId
            };
            list.Add(item);

            return list;
        }


        //private void bBulkInsert_Click(object sender, EventArgs e)
        //{
        //    List<FoodIntolerance> foodIntolerances = JsonConvert.DeserializeObject<List<FoodIntolerance>>(tbJson.Text);

        //    MongoClient client = new MongoClient();
        //    var db = client.GetDatabase("healthyhuntingdb");
        //    var collection = db.GetCollection<FoodIntolerance>("foodintolerance");
        //    collection.InsertMany(foodIntolerances);
        //}

        private void btnInsertGeneratedData_Click(object sender, EventArgs e)
        {
            if (DataGenerator.InsertGeneratedData(richTextBox, Convert.ToInt32(numNumOfUsers.Value), Convert.ToInt32(numNumOfRestaurants.Value), Convert.ToInt32(numMaxNumOfMealsPerRestaurants.Value), Convert.ToInt32(numNumOfSearchAnalyticsData.Value)))
            {
                MessageBox.Show("OK");
            }
            else
            {
                MessageBox.Show("ERROR");
            }
        }

        private void btnDeleteDataBase_Click(object sender, EventArgs e)
        {
            MongoUrl url = new MongoUrl("mongodb://localhost:27017");
            MongoClient client = new MongoClient(url);
            //MongoClient client = new MongoClient();
            var db = client.GetDatabase("healthyhuntingdb");
            db.DropCollection("adminrole");
            db.DropCollection("adminuser");
            db.DropCollection("foodintolerance");
            db.DropCollection("user");
            db.DropCollection("mealtype");
            db.DropCollection("cuisinetype");
            db.DropCollection("macro");
            db.DropCollection("restaurant");
            db.DropCollection("searchanalyticsdata");
            db.DropCollection("diary");

            MessageBox.Show("OK");
        }

        //private void btnRandomLoc_Click(object sender, EventArgs e)
        //{
        //    Random rand = new Random();
        //    tbLatitude.Text = DataGenerator.RandomLeedsLatitude(rand).ToString();
        //    tbLongitude.Text = DataGenerator.RandomLeedsLongitude(rand).ToString();
        //}
    }
}
