using Microsoft.AspNetCore.Mvc;
using RegistrationApp.Data;
using RegistrationApp.Models;
using System.Collections.Generic;

namespace RegistrationApp.Controllers
{
    public class GuestController : Controller
    {
        private readonly ApplicationDbContext _db;

        public GuestController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Guest> objList = _db.Guest;
            return View(objList);
        }

        //Get of CREATE
        public IActionResult Create()
        {
            return View();
        }

        //Post of CREATE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Guest obj)
        {
            if (ModelState.IsValid)
            {
                _db.Guest.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);

        }

        //Get of Edit
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.Guest.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        //Post of Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Guest obj)
        {
            if (ModelState.IsValid)
            {
                _db.Guest.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);

        }

        //Get of Delete
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.Guest.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        //Post of Delete
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePOST(int? id)
        {
            var obj = _db.Guest.Find(id);

            if (obj == null)
            {
                return NotFound();
            }
            _db.Guest.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}
