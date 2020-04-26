using MinhaCelula.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaCelula.DAL.DAL
{
    public class UsuarioDAL
    {
        public Usuario GetUsuarioById(int userId)
        {
            using (DatabaseContext contexto = new DatabaseContext())
            {
                return contexto.Usuarios.Find(userId);
            }
        }

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

        public void CriarAlterarUsuario(Usuario Us)
        {
            using (DatabaseContext contexto = new DatabaseContext())
            {
                //if(Us.UsuarioId != 0)
                //Us.PessoaId = contexto.Usuarios.Where(U => U.UsuarioId == Us.UsuarioId).Select(U => U.PessoaId).Single();

                Us.Status = UserStatus.PrimeiroAcesso;

                try
                {
                    contexto.Usuarios.AddOrUpdate(Us);
                    contexto.SaveChanges();
                }
                catch (Exception ex)
                {
                    Us.MsgErro = ex.Message;
                }
            }
        }

        public List<Usuario> GetAllUsers2()
        {
            using (DatabaseContext Contexto = new DatabaseContext())
            {
                return Contexto.Usuarios.ToList();
            }
           
        }

        public IEnumerable<Usuario> GetAllUsers()
        {
            DatabaseContext Contexto = new DatabaseContext();
            return Contexto.Usuarios;
        }

        public void RemoverUsuario(int UsuarioId)
        {
            using (DatabaseContext Contexto = new DatabaseContext())
            {
                Usuario Us = new Usuario() { UsuarioId = UsuarioId };

                Contexto.Usuarios.Attach(Us);

                Contexto.Usuarios.Remove(Us);

                Contexto.SaveChanges();
            }         
        }
    }
}
