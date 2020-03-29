using System.Web.Mvc;

namespace FirstAppWeb.Controllers
{
    public class HomeController : Controller
    {
        [Authorize] //indica que este recurso solo es valido si el usuario esta autenticado mediante las tecnicas de cookie+session
        //el engine de ASP.NET+MVC tiene la capacidad de detectar y analizar si para el cliente que esta solicitando un recurso
        //hay una sesion generada, se explica un poco mas en el controller de login
        public ActionResult Index()
        {
            return View();
        }

        [Authorize]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [Authorize]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}