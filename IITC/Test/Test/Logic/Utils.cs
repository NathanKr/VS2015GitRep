using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Test.Logic
{
    public class Utils
    {
        public static string GetServerRoot(
            HttpServerUtilityBase server)
        {
            return server.MapPath(@"\");
        }

        public static int ComputeResult(int a , int b)
        {
            return (a + b);
        }

        
    }
}