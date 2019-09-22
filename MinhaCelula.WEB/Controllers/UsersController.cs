using MinhaCelula.BLL;
using MinhaCelula.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MinhaCelula.WEB.Controllers
{
    public class UsersController : Controller
    {
        // GET: Users
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CadastrarUsuario(string email)
        {
            ViewBag.Usuario = "Creiçu";

            Usuario Usuario = new UsuarioBLL().NovoUsuario(ref email);

            if (Usuario.UsuarioId == 0)
                return Json(string.Concat("[ERRO]",email));
            else return View("_TuplaUsuario", Usuario);
        }
    }
}