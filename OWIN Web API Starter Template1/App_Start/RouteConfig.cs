﻿using System.Web.Http;

namespace Latsos.Web
{
    /// <summary>
    /// Represents route configuration.
    /// </summary>
    public class RouteConfig
    {
        /// <summary>
        /// Configures Web API routes.
        /// </summary>
        /// <param name="configuration"></param>
        public static void Configure(HttpConfiguration configuration)
        {
            configuration.MapHttpAttributeRoutes();

          

           
        }
    }
}