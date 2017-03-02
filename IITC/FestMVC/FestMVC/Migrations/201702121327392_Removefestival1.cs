namespace FestMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Removefestival1 : DbMigration
    {
        public override void Up()
        {
           // DropTable("dbo.Festivals");
        }
        
        public override void Down()
        {
           /* CreateTable(
                "dbo.Festivals",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                        StartDateTime = c.DateTime(nullable: false),
                        EndDateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            */
        }
    }
}
