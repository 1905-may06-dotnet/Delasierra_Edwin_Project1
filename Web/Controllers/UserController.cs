using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PizzaBox.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PizzaBox.Web.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserRepository db;
        public User CurrentUser;
        

        public UserController(IUserRepository db)
        {
            this.db = db;
        }
        Models.User u;
        List<Models.User> userList = new List<Models.User>();

        //public HttpContext Context => context;

        public ActionResult Index()
        {
            var users = db.GetAllUsers();
            foreach (var user in users)
            {
                u = new Models.User();
                u.Username = user.Username;
                u.Password = user.Password;
                userList.Add(u);
            }

            return View(userList);
        }

        public ActionResult Details(string username)
        {
            var user = db.GetUser(username);
            u = new Models.User();
            u.Username = user.Username;
            u.Password = user.Password;
            
            return View(u);
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(IFormCollection collection, Models.User user)
        {
            Domain.User dmu = new User();
            dmu.Username = user.Username;
            dmu.Password = user.Password;

            try
            {
                if (db.GetUser(dmu.Username) != null)
                {
                    var dtu = db.GetUser(dmu.Username);
                    if (dtu.Password == dmu.Password)
                    {
                        CurrentUser = dmu;
                        //HttpContext.Session("Username") = dmu.Username;
                        return RedirectToRoute(new { controller = "Home", action = "MainMenu" });
                    }
                    ModelState.AddModelError("Password", "Username and/or password are incorrect");
                    return View(user);
                }
                ModelState.AddModelError("Username", "Username does not exist in system");
                return View(user);
            }
            catch
            {
                return View();
            }
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection, Models.User user)
        {
            Domain.User dmu = new User();
            dmu.Username = user.Username;
            dmu.Password = user.Password;

            try
            {
                db.AddUser(dmu);
                db.Save();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit(string username)
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(string username, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                if (db.GetUser(username) != null)
                {
                    db.EditUser(db.GetUser(username));
                    db.Save();
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(string username)
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(string username, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                db.DeleteUser(username);
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
