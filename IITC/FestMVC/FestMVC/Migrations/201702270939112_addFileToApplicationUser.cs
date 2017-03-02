namespace FestMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addFileToApplicationUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "File", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "File");
        }
    }
}
