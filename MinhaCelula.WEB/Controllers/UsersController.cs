using MinhaCelula.BLL;
using MinhaCelula.Model;
using MinhaCelula.WEB.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace MinhaCelula.WEB.Controllers
{
    public class UsersController : Controller
    {
        // GET: Users
        public ActionResult Index()
        {
            ViewBag.Celulas = new CelulaBLL().GetAllCelulas();
            return View(new UsuarioBLL().GetAllUsers2());
        }

        [HttpPost]
        public ActionResult CadastrarUsuario(Usuario Us, Pessoa P)
        {
            new PessoaBLL().CriarAlterarPessoa(P);
            Us.PessoaId = P.PessoaId;
            new UsuarioBLL().CriarAlterarUsuario(Us);
            Us.Nome = P.Name;
            
            if (Us.UsuarioId == 0 || P.PessoaId == 0)
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