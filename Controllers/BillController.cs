using KeepTrack.Database;
using KeepTrack.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KeepTrack.Controllers
{
    public class BillController : Controller
    {
        private DatabaseContext _db;

        public BillController(DatabaseContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var bills = _db.Bills.ToList();
            return View(bills);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View(new Bill());
        }

        [HttpPost]
        public IActionResult Create([FromForm]Bill bill)
        {
            if (ModelState.IsValid)
            {
                _db.Bills.Add(bill);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View("Index");
        }

        [HttpGet]
        public IActionResult Update(int BillId)
        {
            Bill bill = _db.Bills.Find(BillId);
            return View("Create", bill);
        }

        [HttpPost]
        public IActionResult Update([FromForm]Bill bill)
        {
            if (ModelState.IsValid)
            {
                _db.Bills.Update(bill);
                _db.SaveChanges();
                return View("Index");
            }
            return View("Create");
        }
    }
}
