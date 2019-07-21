using System.Web.Http;
using UtilizationTracker.Business;

namespace UtilizationTracker
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            //config.MapHttpAttributeRoutes();
            config.Routes.MapHttpRoute(
             name: "DefaultApi1",
             routeTemplate: "api/{controller}/{action}/{id}",
             defaults: new { id = RouteParameter.Optional }
            );



            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            UnitySettings.RegisterComponents(config);
        }
    }
}
