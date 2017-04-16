using System.Web.Http;
using Microsoft.Owin;
using Owin;


[assembly: OwinStartup(typeof(SwimmingPool.Web.Startup))]

namespace SwimmingPool.Web
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration();
            WebApiConfig.Register(config);
            NinjectConfig.Register(config);

            GlobalConfiguration.Configure(WebApiConfig.Register);
            

            // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=316888
        }
    }
}
