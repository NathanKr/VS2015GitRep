namespace FestMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Festival1RemoveDateTime1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Festival1", "StartDateTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.Festival1", "EndDateTime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Festival1", "EndDateTime");
            DropColumn("dbo.Festival1", "StartDateTime");
        }
    }
}
