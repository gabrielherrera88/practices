using System;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace FirstAppWeb
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        void Application_End(object sender, EventArgs e) {
            //se ejecuta cuando se cierra la aplicación
        }

        void Application_Error(object sender, EventArgs e) {
            //se ejecuta al producirse un error no controlado
        }

        void Application_BeginRequest(object sender, EventArgs e) {
            //se ejecuta por cada peticion del cliente, ya sea una url, una imagen, etc
        }

        void Application_EndRequest(object sender, EventArgs e) {
            //se ejecuta cuando finaliza una peticion
        }

        void Session_Start(object sender, EventArgs e) {
            //se ejecuta cuando se inicia una nueva sesión, por ejemplo lo podriamos para controlar usuarios activos
        }

        void Session_End(object sender, EventArgs e) {
            //se ejecuta cuando finaliza una sesión.
            //Nota: el evento Session_End se desencadena sólo cuando el modo sessionstate
            //se establece como InProc en el archivo Web.config. Si el modo de sesión se establece como StateServer 
            //o SQLServer, el evento no se genera.
        }
    }
}