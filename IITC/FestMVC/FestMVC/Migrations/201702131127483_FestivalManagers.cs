namespace FestMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FestivalManagers : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FestivalManagers",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        UserId = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.FestivalManagers");
        }
    }
}
