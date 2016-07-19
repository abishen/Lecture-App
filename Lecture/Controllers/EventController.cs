using Lecture.DbLayer;
using Lecture.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lecture.Controllers
{
    public class EventController : Controller
    {
        private readonly IEventManager _eventManager;

        public EventController()
        {
            _eventManager = new EventManager();
        }
        // GET: Event
        public ActionResult Index()

        {



            ViewBag.Admin = User.IsInRole("Admin");
            return View(_eventManager.Events());
        }

        [Authorize(Roles="Admin")]

        public ActionResult Create()
        {
            return View();
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public ActionResult Create([Bind(Exclude ="Id, IsCancelled")] Event eventInfo)
        {
            if (!ModelState.IsValid) { return View(); }

            eventInfo.IsCancelled = false;
            _eventManager.Add(eventInfo);
            return View("Index", _eventManager.Events());
        }
        [Authorize(Roles = "Admin")]
        [HttpGet]
        public ActionResult Edit(int id)
        {
            return View(_eventManager.Details(id));
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public ActionResult Edit(Event eventInfo)
        {
            _eventManager.Edit(eventInfo);
            return View("Index", _eventManager.Events());
        }

        public ActionResult Details(int id)
        {
            return View (_eventManager.Details(id));
        }

        public ActionResult CancelledEvents()
        {
            return View(_eventManager.Events(true));
        }
    }
}