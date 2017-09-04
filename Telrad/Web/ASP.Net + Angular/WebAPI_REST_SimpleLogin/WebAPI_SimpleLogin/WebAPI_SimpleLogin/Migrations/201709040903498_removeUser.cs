namespace WebAPI_SimpleLogin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removeUser : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Users", "Role");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "Role", c => c.String());
        }
    }
}
