namespace FestMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Festival1Id1 : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Events", "Festival1Id");
            AddForeignKey("dbo.Events", "Festival1Id", "dbo.Festival1", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Events", "Festival1Id", "dbo.Festival1");
            DropIndex("dbo.Events", new[] { "Festival1Id" });
        }
    }
}
