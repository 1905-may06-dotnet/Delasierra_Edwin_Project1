using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PizzaBox.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PizzaBox.Web.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderRepository db;
        public User CurrentUser;
        public OrderController(IOrderRepository db)
        {
            this.db = db;
        }
        Models.Order o;
        List<Models.Order> orderList = new List<Models.Order>();

        public ActionResult Index()
        {
            var orders = db.GetAllOrders();
            foreach (var order in orders)
            {
                o = new Models.Order();
                o.id = order.id;
                o.locationid = order.locationId;
                o.userid = order.userId;
                o.orderTime = order.time;
                o.cost = order.totalCost;
                
                orderList.Add(o);
            }

            return View(orderList);
        }

        public ActionResult Details(int id)
        {
            var order = db.GetOrder(id);
            o = new Models.Order();
            o.id = order.id;
            o.locationid = order.locationId;
            o.userid = order.userId;
            o.orderTime = order.time;
            o.cost = order.totalCost;

            return View(o);
        }
        [HttpGet]
        public IActionResult PlaceOrder()
        {
            return View();
        }

        [HttpPost]
        public ActionResult PlaceOrder(IFormCollection collection, Models.Order order)
        {
            Domain.Order dmu = new Order();
            dmu.id = order.id;
            dmu.userId = order.userid;
            dmu.locationId = order.locationid;
            dmu.time = DateTime.Now;
            dmu.totalCost = 0;
            try
            {
                db.AddOrder(dmu);
                db.Save();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit(int id)
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                if (db.GetOrder(id) != null)
                {
                    db.EditOrder(db.GetOrder(id));
                    db.Save();
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                db.DeleteOrder(id);
                db.Save();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
