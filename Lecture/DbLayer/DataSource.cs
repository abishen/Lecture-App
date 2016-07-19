using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Lecture.Models;

namespace Lecture.DbLayer
{
    public class DataSource : DbContext
    {


        public DataSource()
            : base("DefaultConnection")
        {

        }

        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Publications> Publication { get; set; }
        public DbSet<biograph> Biographs { get; set; }
        public DbSet<Announcements> Announcements { get; set; }
        public DbSet<Event> Events { get; set; }
    }
}