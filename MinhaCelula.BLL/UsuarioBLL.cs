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
        public void NovoUsuario(Usuario Us)
        {
            new UsuarioDAL().NovoUsuario(Us);
        }

        public IEnumerable<Usuario> GetAllUsers()
        {
            return new UsuarioDAL().GetAllUsers();
        }
    }
}
