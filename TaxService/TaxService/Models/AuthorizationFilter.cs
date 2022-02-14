using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace TaxService.Models
{
    public class AuthorizationFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            try
            {
                if (HttpContext.Current.Session["UserID"] != null && HttpContext.Current.Session["AppSecurityKey"].ToString() == ConfigurationManager.AppSettings.Get("AppSecurityKey"))
                {

                }
                else
                {
                    filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary { { "controller", "Admin" }, { "action", "Index" } });
                }
            }
            catch
            {
                filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary { { "controller", "Admin" }, { "action", "Index" } });
            }
            base.OnActionExecuting(filterContext);
        }

    }
}