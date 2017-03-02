namespace FestMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Junk1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Events", "Junk", c => c.Long(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Events", "Junk");
        }
    }
}
