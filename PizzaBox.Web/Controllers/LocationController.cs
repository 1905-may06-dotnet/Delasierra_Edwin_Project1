using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PizzaBox.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PizzaBox.Web.Controllers
{
    public class LocationController : Controller
    {
        private readonly ILocationRepository db;
        public Location CurrentLocation;
        public LocationController(ILocationRepository db)
        {
            this.db = db;
        }

        Models.Location loc;
        List<Models.Location> locationList = new List<Models.Location>();
        // GET: /<controller>/
        public ActionResult Index()
        {
            var locs = db.GetAllLocations();
            foreach (var location in locs)
            {
                loc = new Models.Location();
                loc.id = location.locationID;
                loc.name = location.name;
                loc.street1 = location.street1;
                loc.street2 = location.street2;
                loc.city = location.city;
                loc.state = location.state;
                loc.zipcode = location.zipcode;
                locationList.Add(loc);
            }

            return View(locationList);
        }

        //[HttpPost]
        public ActionResult Select()
        {
            var locs = db.GetAllLocations();
            foreach (var location in locs)
            {
                loc = new Models.Location();
                loc.id = location.locationID;
                loc.name = location.name;
                loc.street1 = location.street1;
                loc.street2 = location.street2;
                loc.city = location.city;
                loc.state = location.state;
                loc.zipcode = location.zipcode;
                locationList.Add(loc);
            }
            
            return View(locationList);
        }

        [HttpGet]
        public IActionResult PlaceOrder()
        {
            return View();
        }

        [HttpPost]
        public ActionResult PlaceOrder(Models.Location loc)
        {
            try
            {
                TempData["LocationID"] = loc.id;
                TempData.Keep();
                return RedirectToRoute(new { controller = "Pizza", action = "Create" });
            }
            catch
            {
                return View();
            }
        }
    }
}
