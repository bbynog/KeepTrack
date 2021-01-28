using KeepTrack.Database;
using KeepTrack.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KeepTrack.Controllers
{
    public class LoginController : Controller
    {
        private DatabaseContext _db;

        public LoginController(DatabaseContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View(new User());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View(new User());
        }

        [HttpPost]
        public IActionResult Create([FromForm]User user)
        {
            if (ModelState.IsValid)
            {
                _db.Users.Add(user);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
