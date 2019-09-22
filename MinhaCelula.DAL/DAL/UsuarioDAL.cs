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
        public Usuario NovoUsuario(ref string email)
        {
            using (DatabaseContext contexto = new DatabaseContext())
            {
                Usuario Us = new Usuario()
                {
                    Status = UserStatus.PrimeiroAcesso,
                    UserName = email                    
                };

                try
                {
                    contexto.Usuarios.Add(Us);
                    contexto.SaveChanges();
                }
                catch(Exception ex)
                {
                    email = ex.Message;
                }

                return Us;
            }
        }
    }
}
