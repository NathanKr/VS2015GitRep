namespace FestMVC.Migrations
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<FestMVC.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "FestMVC.Models.ApplicationDbContext";
        }

        void resetTable(ApplicationDbContext context, string strTableName)
        {
            context.Database.ExecuteSqlCommand(string.Format("delete from {0}", strTableName));
            context.Database.ExecuteSqlCommand(string.Format("DBCC CHECKIDENT ( {0}  , RESEED , 0 )", strTableName));
        }



        protected override void Seed(FestMVC.Models.ApplicationDbContext context)
        {
            initRooms(context);
        }

        private void initRooms(ApplicationDbContext context)
        {
            resetTable(context, "Rooms");


            IEnumerable<FestMVC.Models.Room> listRooms =
                new List<FestMVC.Models.Room>()
             {
                 new FestMVC.Models.Room()
                 {
                     Name = "room A"
                 }
             };

            context.Rooms.AddRange(listRooms);
        }
    }
    
}
