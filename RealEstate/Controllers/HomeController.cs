using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RealEstate.Controllers
{
    public class HomeController : Controller
    {
        IMongoDatabase database;

        public HomeController()
        {

            //MongoClientSettings settings = new MongoClientSettings() { };
            var client = new MongoClient("mongodb://localhost:27017");
            var settings = client.Settings;
            database = client.GetDatabase("realestate");
        }
        public ActionResult Index()
        {
            //vdatabase.
            //  var collection = database.GetCollection<Person>("bar");
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}