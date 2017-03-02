namespace FestMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Festival1Id : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Events", "Festival1Id", c => c.Long(nullable: false));
            DropColumn("dbo.Events", "FestId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Events", "FestId", c => c.Long(nullable: false));
            DropColumn("dbo.Events", "Festival1Id");
        }
    }
}
