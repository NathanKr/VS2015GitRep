using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_empty.Logic
{
    public class Utils
    {
        public static bool DoesBookExist(HttpServerUtilityBase server ,string bookName)
        {
            bool bDoesExist = false;
            string virtualFile = "~/storage/books.txt";
            string physicalFile = server.MapPath(virtualFile);
            string[] arFileLines = System.IO.File.ReadAllLines(physicalFile);
            foreach (string strBookLine in arFileLines)
            {
                string[] arLineSplited = strBookLine.Split(',');
                if (arLineSplited[0] == bookName)
                {
                    bDoesExist = true;
                    break;
                }
            }

            return bDoesExist;
        }
    }
}