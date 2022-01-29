using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace LegacyMVCAPP.Auth
{
    public class CustomAuthorizeAttribute : AuthorizeAttribute
    {
        public override void OnAuthorization(AuthorizationContext filterContext)
        {

            var cookie = filterContext.HttpContext.Request.Cookies.Get(".AspNetCore.Identity.Application");


        }
    }
}