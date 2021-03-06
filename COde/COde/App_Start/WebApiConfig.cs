﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web.Http;

namespace COde
{
    public static class WebApiConfig
    {
        public static string FilePath()
        {
            string path = string.Empty;
            try
            {
                var appSettings = ConfigurationManager.AppSettings;
                path = appSettings["TempFileDB"] ?? "Not Found";
                
            }
            catch (ConfigurationErrorsException)
            {
                
            }
            return path;
        }

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
        }
    }
}
