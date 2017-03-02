namespace FestMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Event : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        startTime = c.DateTime(nullable: false),
                        endTime = c.DateTime(nullable: false),
                        FestId = c.Long(nullable: false),
                        InstructorId = c.Long(nullable: false),
                        RoomId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Festival1", "Location", c => c.String());
            AddColumn("dbo.Festival1", "StartDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Festival1", "EndDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Festival1", "FesivalManagerId", c => c.Long(nullable: false));
            DropColumn("dbo.Festival1", "StartDateTime");
            DropColumn("dbo.Festival1", "EndDateTime");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Festival1", "EndDateTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.Festival1", "StartDateTime", c => c.DateTime(nullable: false));
            DropColumn("dbo.Festival1", "FesivalManagerId");
            DropColumn("dbo.Festival1", "EndDate");
            DropColumn("dbo.Festival1", "StartDate");
            DropColumn("dbo.Festival1", "Location");
            DropTable("dbo.Events");
        }
    }
}
