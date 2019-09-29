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
            return View(new UsuarioBLL().GetAllUsers());
        }

        [HttpPost]
        public ActionResult CadastrarUsuario(Usuario Us)
        {
            new UsuarioBLL().CriarAlterarUsuario(Us);

            if (Us.UsuarioId == 0)
                return Json(string.Concat("[ERRO]", Us.MsgErro));
            else
            {
                ICollection<Usuario> Users = new HashSet<Usuario>();
                Users.Add(Us);
                return View("_TuplaUsuario", Users);
            }
        }

        [HttpPost]
        public ActionResult RemoverUsuario(int UsuarioId)
        {
            return Json(new UsuarioBLL().RemoverUsuario(UsuarioId));
        }
    }
}