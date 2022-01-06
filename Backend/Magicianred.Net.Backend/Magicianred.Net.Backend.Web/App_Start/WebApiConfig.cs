using System.Linq;
using System.Net.Http.Headers;
using System.Web.Http;

namespace Magicianred.Net.Backend.Web
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.Formatters.XmlFormatter.SupportedMediaTypes.Remove(
                config.Formatters.XmlFormatter.SupportedMediaTypes.FirstOrDefault(t => t.MediaType == "application/xml"));

            config.Formatters.JsonFormatter.SupportedMediaTypes.Remove(
                config.Formatters.JsonFormatter.SupportedMediaTypes.FirstOrDefault(t => t.MediaType == "text/html"));

            config.Formatters.JsonFormatter.SupportedMediaTypes
                .Add(new MediaTypeHeaderValue("application/json"));
        }
    }
}
