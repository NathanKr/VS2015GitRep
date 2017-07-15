using System.Web;
using System.Web.Mvc;

namespace MVC_Email_Confirmation
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
