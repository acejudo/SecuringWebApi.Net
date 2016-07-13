using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Controllers;
/*ref: http://code.tutsplus.com/tutorials/securing-aspnet-web-api--cms-26012*/
namespace SecuringWebApi.CustomAttribute
{
    public class RestrictIPsAttribute : System.Web.Http.AuthorizeAttribute
    {
        protected override bool IsAuthorized(HttpActionContext context)
        {
            var ip = HttpContext.Current.Request.UserHostAddress;

            //check for ip here
            if (ip.Contains(""))
            {
                return true;
            }
            return false;
        }
    }
}