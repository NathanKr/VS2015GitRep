using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspAjaxProgress.Logic
{
        public class ReportUtils
        {
            /*
             * this will cause the client ajax handler OnFailure to be called and not OnSuccess
             */
            public static ActionResult GetAjaxError(Errors error)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest, error.ToString());
            }

            public static ActionResult GetAjaxOk()
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.OK);
            }
        }
}