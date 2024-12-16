using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using System.Web.Http;

[assembly: OwinStartup(typeof(OWIN.Startup))]
namespace OWIN
{
        public class Startup
        {
            public void Configuration(IAppBuilder app)
            {
                var config = new HttpConfiguration();

                // Web API routes
                config.MapHttpAttributeRoutes();

                config.Routes.MapHttpRoute(
                    name: "DefaultApi",
                    routeTemplate: "api/{controller}/{id}",
                    defaults: new { id = RouteParameter.Optional }
                );

                app.UseWebApi(config);
            }
        }
}
