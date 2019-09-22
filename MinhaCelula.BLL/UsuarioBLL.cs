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
        public Usuario NovoUsuario(ref string email)
        {
            return new UsuarioDAL().NovoUsuario(ref email);
        }
    }
}
