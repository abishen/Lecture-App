namespace Lecture.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedFieldintable : DbMigration
    {
        public override void Up()
        {

            AddColumn("dbo.AspNetUsers","Firstname",c => c.String());
            AddColumn("dbo.AspNetUsers", "Lastname", c => c.String());

          
        }
        
        public override void Down()
        {
        }
    }
}
