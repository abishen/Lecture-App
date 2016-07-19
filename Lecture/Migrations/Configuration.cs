namespace Lecture.Migrations
{
    using Lecture.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Lecture.DbLayer.DataSource>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(Lecture.DbLayer.DataSource context)
        {
            ApplicationDbContext db2Context = new ApplicationDbContext();
            var roleManager1 = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(db2Context));
            var userManager1 = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(db2Context));

            var role1 = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
            role1.Name = "Admin";
            roleManager1.Create(role1);

            var adminUser1 = userManager1.FindByEmail("abis_100@hotmail.com");
            if (adminUser1 != null)
            {
                userManager1.AddToRole(adminUser1.Id, LectureConstants.UserRoles.Admin.ToString());
            }

            
        }
    }
}
