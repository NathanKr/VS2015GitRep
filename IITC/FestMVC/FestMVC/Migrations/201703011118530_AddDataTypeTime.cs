namespace FestMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDataTypeTime : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Festival1", "StartTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.Festival1", "EndTime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Festival1", "EndTime");
            DropColumn("dbo.Festival1", "StartTime");
        }
    }
}
