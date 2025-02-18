﻿using Castle.Windsor;
using Newtonsoft.Json.Serialization;
using System.Linq;
using System.Net.Http.Formatting;
using System.Web.Http;
using System.Web.Http.Dispatcher;
using TejeratBankReporting.Dependency;

public static class WebApiConfig
{
    public static void Register(HttpConfiguration config, IWindsorContainer container)
    {
        MapRoutes(config);
        RegisterControllerActivator(container);
    }
    public static void MapRoutes(HttpConfiguration config)
    {


        // Web API routes
        config.MapHttpAttributeRoutes();

           config.Routes.MapHttpRoute(
            name: "DefaultApi",
            routeTemplate: "api/{controller}/{id}",
            defaults: new { id = RouteParameter.Optional });
          config.Routes.MapHttpRoute(
          name: "ControllerAndAction",
            routeTemplate: "api/{controller}/{action}/{id}",
         defaults: new { id = RouteParameter.Optional }
          );


        var jsonFormatter = config.Formatters.OfType<JsonMediaTypeFormatter>().First();
        jsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
    }
    private static void RegisterControllerActivator(IWindsorContainer container)
    {
        GlobalConfiguration.Configuration.Services.Replace(typeof(IHttpControllerActivator),
            new WindsorCompositionRoot(container));
    }
}