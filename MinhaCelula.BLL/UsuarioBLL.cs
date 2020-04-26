using System;
using System.Collections.Generic;
using System.Linq;
using MinhaCelula.DAL.DAL;
using MinhaCelula.Model;

namespace MinhaCelula.BLL
{
    public class UsuarioBLL
    {

        public Usuario GetUsuarioById(int userId)
        {
            return new UsuarioDAL().GetUsuarioById(userId);
        }

        public void CriarAlterarUsuario(Usuario Us)
        {
            Random random = new Random();
            const string chars = "abcdefghijklmnozABCDEFGHIJKLMNOZ1234567890@#$%&*!";
            Us.Password = new string(Enumerable.Repeat(chars, 10).Select(s => s[random.Next(s.Length)]).ToArray());

            new UsuarioDAL().CriarAlterarUsuario(Us);
        }

        public IEnumerable<Usuario> GetAllUsers2()
        {
            List<Usuario> Users = new UsuarioDAL().GetAllUsers2();
            IEnumerable<Pessoa> People = new PessoaDAL().GetAllPessoas();

            foreach (Usuario Us in Users)
            {
                Pessoa p = People.Single(P => P.PessoaId == Us.PessoaId);
                Us.Nome = p.Name;
                Us.PessoaId = p.PessoaId;
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
