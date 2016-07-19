using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Lecture.Models
{
    public class User
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public IList<Microsoft.AspNet.Identity.EntityFramework.IdentityUserRole> Roles { get; set; }
    }
}