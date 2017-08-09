using Cibertec.RealTime.App_Start;
using Microsoft.Owin.Cors;
using Owin;
using System.Web.Http;

namespace Cibertec.RealTime
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseCors(CorsOptions.AllowAll);
                     
            var httpConfig = new HttpConfiguration();
            WebApiConfig.Register(httpConfig);

            app.MapSignalR();

            app.UseWebApi(httpConfig);            
        }
    }
}
