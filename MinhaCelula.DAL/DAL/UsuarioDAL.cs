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
        public int NovoUsuario(Usuario us)
        {
            using (DatabaseContext contexto = new DatabaseContext())
            {
                return 0;
            }
        }
    }
}
