using Lecture.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lecture.DbLayer
{
    public class EventManager : IEventManager
    {
        private DataSource _db = new DataSource();
        public void Add(Models.Event eventInfo)
        {
            _db.Events.Add(eventInfo);
            _db.SaveChanges();
        }

        public void Edit(Models.Event eventInfo)
        {
            var existing = Details(eventInfo.Id);
            existing.Date = eventInfo.Date;
            existing.IsCancelled = eventInfo.IsCancelled;
            existing.Location = eventInfo.Location;
            existing.Name = eventInfo.Name;
            existing.Presenter = eventInfo.Presenter;
            _db.SaveChanges();
        }

        public Models.Event Details(int id)
        {
            return _db.Events.Where(e => e.Id == id).FirstOrDefault();
        }

        public List<Models.Event> Events(bool isCancelled = false)
        {
            return _db.Events.Where(e => e.IsCancelled ==  isCancelled).ToList<Event>();
        }
    }
}