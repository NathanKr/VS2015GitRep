namespace FestMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FestivalAdddateTime : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Festivals", "StartDateTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.Festivals", "EndDateTime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Festivals", "EndDateTime");
            DropColumn("dbo.Festivals", "StartDateTime");
        }
    }
}
