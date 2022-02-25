using Microsoft.AspNetCore.Mvc;
using RegistrationApp.Data;
using RegistrationApp.Models;
using System.Collections.Generic;

namespace RegistrationApp.Controllers
{
    public class StaffController : Controller
    {
        private readonly ApplicationDbContext _db;
        public StaffController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Staff> objList = _db.Staff;
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
        public IActionResult Create(Staff obj)
        {
            if (ModelState.IsValid)
            {
                _db.Staff.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        
        }

        //Get of Edit
        public IActionResult Edit(int? id)
        {
            if(id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.Staff.Find(id);
            if(obj== null)
            {
                return NotFound();
            }
            return View(obj);
        }

        //Post of Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Staff obj)
        {
            if (ModelState.IsValid)
            {
                _db.Staff.Update(obj);
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
            var obj = _db.Staff.Find(id);
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
            var obj = _db.Staff.Find(id);

            if (obj == null)
            {
                return NotFound();
            }
                _db.Staff.Remove(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");

        }

    }
}
