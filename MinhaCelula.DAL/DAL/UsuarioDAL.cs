using MinhaCelula.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaCelula.DAL.DAL
{
    public class UsuarioDAL
    {
        public void NovoUsuario(Usuario Us)
        {
            using (DatabaseContext contexto = new DatabaseContext())
            {
                Us.Status = UserStatus.PrimeiroAcesso;

                try
                {
                    contexto.Usuarios.Add(Us);
                    contexto.SaveChanges();
                }
                catch(Exception ex)
                {
                    Us.MsgErro = ex.Message;
                }
            }
        }

        public IEnumerable<Usuario> GetAllUsers()
        {
            DatabaseContext Contexto = new DatabaseContext();
            return Contexto.Usuarios;
        }
    }
}
