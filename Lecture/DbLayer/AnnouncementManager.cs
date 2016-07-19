using Lecture.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lecture.DbLayer
{
    public class AnnouncementManager : IAnnouncementManager
    {
        DataSource odb = new DataSource();

        public void Create(Announcements announcement)
        {
            odb.Announcements.Add(announcement);
            odb.SaveChanges();
        }

        public void Update(Announcements announcement)
        {
            var exisited = Details(announcement.Id);
            exisited.Bodymessage = announcement.Bodymessage;
            exisited.Title = announcement.Title;
            exisited.DateReleased = announcement.DateReleased;

            odb.SaveChanges();


        }

        public void Delete(int id)
        {
            var announcement = Details(id);
            odb.Announcements.Remove(announcement);
            odb.SaveChanges();
        }

        public List<Announcements> Announcements()
        {
            return odb.Announcements.ToList();
        }



        Announcements Details(int id)
        {
            return odb.Announcements.Where(a => a.Id == id).FirstOrDefault();
        }


        Announcements IAnnouncementManager.Details(int id)
        {
            return odb.Announcements.Where(a => a.Id == id).FirstOrDefault();
        }
    }
}