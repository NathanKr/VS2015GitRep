namespace FestMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EventCategory : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Events", "CategotyId", c => c.Long(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Events", "CategotyId");
        }
    }
}
