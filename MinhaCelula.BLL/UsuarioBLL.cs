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

        public IEnumerable<Usuario> GetAllUsers2()
        {
            List<Usuario> Users = new UsuarioDAL().GetAllUsers2();
            IEnumerable<Pessoa> People = new PessoaDAL().GetAllPessoas();

            foreach (Usuario Us in Users)
            {
                Us.Nome = People.Where(P => P.PessoaId == Us.PessoaId).Select(P => P.Name).Single();
            }

            return Users;
        }


        public IEnumerable<Usuario> GetAllUsers()
        {
            return new UsuarioDAL().GetAllUsers();
        }

            public string RemoverUsuario(int UsuarioId)
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
