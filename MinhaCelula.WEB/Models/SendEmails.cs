using MinhaCelula.Model;
using System;
using System.Configuration;
using System.Net.Mail;
using System.Net.NetworkInformation;

namespace MinhaCelula.WEB.Models
{
  public static class SendEmails
  {
    public static void Enviar(string CorpoEmail, string UserEmail)
    {
      SmtpClient smtp = GetSmtpConfig();
      MailMessage mm = new MailMessage()
      {
        From = new MailAddress(ConfigurationManager.AppSettings["email"]),
        Subject = "Bem vindo ao Minha Célula!",
        Body = CorpoEmail,
        IsBodyHtml = true
      };
      mm.To.Add(UserEmail);

      smtp.Send(mm);
    }

    private static SmtpClient GetSmtpConfig()
    {
      string[] smtp = ConfigurationManager.AppSettings[GetKey(ConfigurationManager.AppSettings["email"])].Split(';');

      SmtpClient SC = new SmtpClient(smtp[0], int.Parse(smtp[1]))
      {
        UseDefaultCredentials = false,
        Credentials = new System.Net.NetworkCredential(ConfigurationManager.AppSettings["email"], ConfigurationManager.AppSettings["pass"]),
        EnableSsl = true
      };

      return SC;
    }

    private static string GetKey(string email)
    {
      return string.Concat(email.Split('@')[1].Split('.')[0], "Smtp");
    }

  }
}