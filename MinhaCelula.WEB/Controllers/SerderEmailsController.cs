using MinhaCelula.BLL;
using MinhaCelula.Model;
using MinhaCelula.WEB.Models;
using System;
using System.Web.Mvc;

namespace MinhaCelula.WEB.Controllers
{
    public class SerderEmailsController : Controller
    {
        // GET: SerderEmails
        public ActionResult EnviarEmail(int userId, string NomeCadastrante = "Fulano Siclano")
        {
            Usuario user = new UsuarioBLL().GetUsuarioById(userId);
            string operacao = "Email enviado com sucesso!";
            try
            {
                
                SendEmails.Enviar(string.Format(EmailBody().ToString(), NomeCadastrante, user.Password), user.Email);
            }
            catch (Exception ex)
            {
                operacao = string.Concat("[ERRO] ", ex.Message);
            }

            return Json(operacao);
                  
           
        }

        public ActionResult EmailBody()
        {
            return View();
        }
    }
}