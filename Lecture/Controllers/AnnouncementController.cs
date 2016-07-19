using Lecture.DbLayer;
using Lecture.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lecture.Controllers
{
    public class AnnouncementController : Controller
    {


        private IAnnouncementManager _db;
        // GET: Anoucement


        public AnnouncementController()
        {
            _db = new AnnouncementManager();
        }
        public ActionResult Index()
        {

            ViewBag.Admin = User.IsInRole("Admin");
            return View(_db.Announcements());
        }

        // GET: Anoucement/Details/5
        public ActionResult Details(int id)
        {
            return View(_db.Details(id));
        }

        // GET: Anoucement/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Anoucement/Create
        [HttpPost]
        public ActionResult Create(Announcements announcement)
        {
            try
            {
                // TODO: Add insert logic here

                if (!ModelState.IsValid) return View();
                _db.Create(announcement);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Anoucement/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_db.Details(id));
        }

        // POST: Anoucement/Edit/5
        [HttpPost]
        public ActionResult Edit(Announcements announcement)
        {
            try
            {
                // TODO: Add update logic here
                _db.Update(announcement);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Anoucement/Delete/5
        //[HttpGet]
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        // POST: Anoucement/Delete/5
        [HttpPost]
        public ActionResult Delete(Announcements announcement)
        {
            try
            {
                // TODO: Add delete logic here
                _db.Delete(announcement.Id);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
