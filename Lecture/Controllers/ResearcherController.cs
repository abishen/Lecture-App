using Lecture.DbLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lecture.Controllers
{
    public class ResearcherController : Controller
    {
        private IStaffManager _db;
        public ActionResult Index()
        {
            _db = new StaffManager();

           var model = _db.StaffsDetails();


            return View(model.ToList());
        }

        // GET: Researcher/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Researcher/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Researcher/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Researcher/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Researcher/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Researcher/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Researcher/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
