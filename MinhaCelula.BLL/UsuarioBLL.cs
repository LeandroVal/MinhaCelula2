using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinhaCelula.DAL.DAL;
using MinhaCelula.Model;

namespace MinhaCelula.BLL
{
    public class UsuarioBLL
    {
        public void CriarAlterarUsuario(Usuario Us)
        {
            new UsuarioDAL().CriarAlterarUsuario(Us);
        }

        public IEnumerable<Usuario> GetAllUsers()
        {
            return new UsuarioDAL().GetAllUsers();
        }

        public string RemoverUsuário(int UsuarioId)
        {
            string success = string.Empty;

            try
            {
                new UsuarioDAL().RemoverUsuario(UsuarioId);
                success = "success";
            }
            catch (Exception ex)
            {
                success = string.Concat("[ERRO]", ex.Message);
            }

            return success;
        }
    }
}
