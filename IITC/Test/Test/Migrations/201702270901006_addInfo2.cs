namespace Test.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addInfo2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Infoes", "Result", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Infoes", "Result");
        }
    }
}
