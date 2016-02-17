using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Newtonsoft.Json;

namespace Application.App
{
    public class MvcApplication : System.Web.HttpApplication
    {
      

        protected void Application_Start()
        {
            UnityConfig.RegisterComponents();
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            //SeedData.Execute();
            JsonConvert.DefaultSettings = () => new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
        }

        public void Application_BeginRequest()
        {

        }

        public void Application_Error()
        {
            Response.Redirect("/");
        }

        public void Application_EndRequest()
        {

        }
    }
}
