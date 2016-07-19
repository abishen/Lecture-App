using Lecture.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture.DbLayer
{
    public interface IAnnouncementManager
    {
        void Create(Announcements announcement);
        void Update(Announcements announcements);
        void Delete(int id);
        List<Announcements> Announcements();
        Announcements Details(int id);
    }
}
