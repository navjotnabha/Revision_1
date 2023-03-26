using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Http;
using Revision_1.App_Start;
using System.IO;

namespace Revision_1
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            


        }
        protected void Application_Error()
        {
            Exception exec=Server.GetLastError();
            String s = "Message: " + exec.Message + ", Type " + exec.GetType().ToString() + ",Source: " + exec.Source;
            StreamWriter sw = File.AppendText(HttpContext.Current.Request.PhysicalApplicationPath + "\\ErrorLog.txt");
            sw.WriteLine(s);
            sw.Close();
        }
    }
}
