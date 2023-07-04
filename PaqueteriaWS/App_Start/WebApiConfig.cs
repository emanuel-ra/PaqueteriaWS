using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace PaqueteriaWS
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Configuración y servicios de Web API
            //var cors = new EnableCorsAttribute("*", "*", "*");
            config.EnableCors();

            // Rutas de Web API
            config.MapHttpAttributeRoutes();            

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            // Convierte las peticion de Objetos a JSON
            var formatter = GlobalConfiguration.Configuration.Formatters.JsonFormatter;
            formatter.SerializerSettings.ContractResolver = new Newtonsoft.Json.Serialization.CamelCasePropertyNamesContractResolver();
        }
    }
}
