using Microsoft.AspNetCore.Mvc;
using MyProject.Data;
using MyProject.Models;
using System.Collections.Generic;

namespace MyProject.Controllers
{
    public class ApplicationTypeController : Controller
    {

        private readonly ApplicationDbConext _db;

        public ApplicationTypeController(ApplicationDbConext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<ApplicationType> objlist = _db.ApplicationType;
            return View(objlist);
        }

        //get - create
        public IActionResult Create()
        {
            return View();
        }
        //post - create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ApplicationType obj)
        {

            if (ModelState.IsValid)
            {
                _db.ApplicationType.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(obj);
        }
    }
}
