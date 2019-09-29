using MinhaCelula.BLL;
using MinhaCelula.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MinhaCelula.WEB.Controllers
{
    public class CelulasController : Controller
    {
        // GET: Celulas
        public ActionResult Index()
        {
            return View(new CelulaBLL().GetAllCelula());
        }

        [HttpPost]
        public ActionResult CadastrarCelula(Celula Cl)
        {
            new CelulaBLL().CriarAlterarCelula(Cl);

            if (Cl.CelulaId == 0)
                return Json(string.Concat("[ERRO]", Cl.MsgErro));
            else
            {
                ICollection<Celula> Celulas = new HashSet<Celula>();
                Celulas.Add(Cl);
                return View("_TuplaCelula", Celulas);
            }
        }

        [HttpPost]
        public ActionResult RemoverCelula(int CelulaId)
        {
            return Json(new CelulaBLL().RemoverCelula(CelulaId));
        }
    }
}