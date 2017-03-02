namespace FestMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveJunk : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Events", "Junk");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Events", "Junk", c => c.Long(nullable: false));
        }
    }
}
