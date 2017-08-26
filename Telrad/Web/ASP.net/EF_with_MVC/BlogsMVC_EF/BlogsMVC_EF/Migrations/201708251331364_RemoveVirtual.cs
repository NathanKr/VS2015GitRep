namespace BlogsMVC_EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveVirtual : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Posts", "BlogId", "dbo.Blogs");
            DropIndex("dbo.Posts", new[] { "BlogId" });
        }
        
        public override void Down()
        {
            CreateIndex("dbo.Posts", "BlogId");
            AddForeignKey("dbo.Posts", "BlogId", "dbo.Blogs", "Id", cascadeDelete: true);
        }
    }
}
