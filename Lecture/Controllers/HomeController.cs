using Lecture.DbLayer;
using Lecture.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lecture.Controllers
{
    public class HomeController : Controller
    {

        private DataSource _db = new DataSource();

        public ActionResult Index()
        {
            //var departments = _db.Staffs.ToList();
   
            //return View(departments);
            ViewBag.Admin = User.IsInRole("Admin");
            

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Staff Staffs) {
            if(ModelState.IsValid){
                _db.Staffs.Add(Staffs);
                _db.SaveChanges();
            }
            return View("Index", _db.Staffs.ToList<Staff>());
        }

        [HttpGet]
        public JsonResult getAccouments()
        {
            IAnnouncementManager _db;
            _db = new AnnouncementManager();
            var model = _db.Announcements();
            return Json(model, JsonRequestBehavior.AllowGet);
        }
    }
}