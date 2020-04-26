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
    public ActionResult EnviarEmail(int userId, string NomeCadastrante = "Pastora XXX")
    {
      Usuario user = new UsuarioBLL().GetUsuarioById(userId);
      string operacao = "Email enviado com sucesso!";
      try
      {
        SendEmails.Enviar(string.Format(Corpo.ToString(), NomeCadastrante, user.Password), user.Email);
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

    private readonly string Corpo =
      @"<h3>Bem vindo ao Minha Célula!</h3>
        <br />

        <p>É um prazer recebê-lo em nosso time!</p>

        <p>Fique a vontade para descobrir recursos, dar sugestões e reportar bugs.</p>

        <p>Principais recursos:</p>
        <ul>
            <li>Gerenciador de células;</li>
            <li>Gerenciador de membros;</li>
            <li>Lista de chamada;</li>
            <li>Registro de oferta;</li>
            <li>Relatórios;</li>
        </ul>
        <br />
        <hr />
        <br />
        <p>Você foi adicionado pelo(a) <b>{0}</b></p>

        <p>Use a seguinte <b>senha</b> para logar em nosso app: <b>{1}</b></p>

        <p>Lembre-se de trocá-la quando entrar!</p>
        <br />
        <br />
        <br />
        <p>Atenciosamente, <b><i>Minha Célula!!!</i></b></p>";
  }
}