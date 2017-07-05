using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ADO_mvc.Logic
{
    public class AdoHelper
    {
        public static string GetConnectionString()
        {
            return @"Data Source = (LocalDB)\MSSQLLocalDB;" +
                                   @"AttachDbFilename = |DataDirectory|\Database1.mdf;" +
                                   "Initial Catalog = DataBase1;" +
                                   " Integrated Security = True ;";
        }
    }
}