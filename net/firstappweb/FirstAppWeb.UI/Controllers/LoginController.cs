using FirstAppWeb.Models;
using System.Web.Mvc;

namespace FirstAppWeb.Controllers
{
    public class LoginController : Controller //todos nuestros controladores de MVC heredaran de la clase Controller, esto nos garantiza que nuestra
        //clase sea un controlador y a demas la clase base nos proporciona y nos abstrae de diferentes situaciones (acceso a recursos sin autenticacion, etc)
    {
        [AllowAnonymous] //indicamos que va a ser un recurso publico y no requiere autenticacion para acceder
        [HttpGet]
        public ViewResult Index() //todos los metodos de un controlador que sirvan para atender solicitudes del lado del cliente deben ser
            //publicos, deben retornar un tipo de dato en particular (ActionResult) el cual determina el resultado de un metodo de accion
            //(puede indicarse cualquiera de sus variantes siendo ActionResult el generico, ViewResult indica que se va a retornar una vista,
            //JsonResult indica que se va a retornar datos serializados en json) y deben tener un nombre (dicho nombre es el que se utilizara
            //del lado del cliente en la url para invocarlo)
        {
            return View("Login"); //le decimos que vista queremos devolver para renderizar
        }

        [AllowAnonymous]
        [HttpPost] //solo es consumible cuando el cliente indica POST en la peticion
        [ValidateAntiForgeryToken] //previene ataques de falcificacion de solicitudes entre sitios (CSRF/XSRF)
        public ActionResult Index(LoginModel loginModel)
        {
            return RedirectToAction("Index", "Home");
        }
    }
}