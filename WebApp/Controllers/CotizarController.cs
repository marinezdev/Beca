using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Controllers
{
    public class CotizarController : Controller
    {
        // GET: Cotizar
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult NuevoRegistro(Models.NuevoUsuario nuevoUsuario, Application.Usuarios usuarios)
        {
            if (nuevoUsuario != null)
            {
                
                return Json(usuarios.UsuarioAgregar(nuevoUsuario.usuario[0]));
            }
            else
            {
                return Json("An Error Has occoured");
            }
        }
    }
}
