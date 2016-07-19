using Lecture.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture.DbLayer
{
    public interface IEventManager
    {
        void Add(Event eventInfo);
        void Edit(Event eventInfo);
        Event Details(int id);
        List<Event> Events(bool isCancelled = false);
    }
}
