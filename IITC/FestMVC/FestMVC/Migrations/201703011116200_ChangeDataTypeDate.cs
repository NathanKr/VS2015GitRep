namespace FestMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeDataTypeDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Festival1", "StartDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Festival1", "EndDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.Festival1", "StartDateTime");
            DropColumn("dbo.Festival1", "EndDateTime");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Festival1", "EndDateTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.Festival1", "StartDateTime", c => c.DateTime(nullable: false));
            DropColumn("dbo.Festival1", "EndDate");
            DropColumn("dbo.Festival1", "StartDate");
        }
    }
}
