using FestMVC.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace FestMVC.Logic
{
    public class Utils
    {
        public static void SaveFile(string strDirectory,
            HttpPostedFileBase file)
        {
            bool isExists = System.IO.Directory.Exists(strDirectory);

            if (!isExists)
                System.IO.Directory.CreateDirectory(strDirectory);

            var path = Path.Combine(strDirectory, file.FileName);
            file.SaveAs(path);
        }

        public static string GetServerRoot(
            HttpServerUtilityBase server)
        {
            return server.MapPath(@"\");
        }

        public static string GetUserImagePath(ApplicationUser user)
        {
            string strDirectory = 
                Path.Combine(ConstantsFest.StorageDir, user.Id);

            return Path.Combine(strDirectory,user.File);
        }
    }
}