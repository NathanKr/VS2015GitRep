namespace AspMvcWithWebApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddField : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "File", c => c.String());
            AddColumn("dbo.Books", "Type", c => c.Int(nullable: false));
            DropColumn("dbo.Books", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Books", "Name", c => c.String());
            DropColumn("dbo.Books", "Type");
            DropColumn("dbo.Books", "File");
        }
    }
}
