using MinhaCelula.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaCelula.DAL.DAL
{
    public class PessoaDAL
    {

        public void NovaPessoa(Pessoa Ps)
        {
            using (DatabaseContext contexto = new DatabaseContext())
            {

                try
                {
                    contexto.Pessoas.Add(Ps);
                    contexto.SaveChanges();
                }
                catch (Exception ex)
                {
                    Ps.MsgErro = ex.Message;
                }
            }
        }

        public void CriarAlterarPessoa(Pessoa Ps)
        {
            using (DatabaseContext contexto = new DatabaseContext())
            {


                try
                {
                    contexto.Pessoas.AddOrUpdate(Ps);
                    contexto.SaveChanges();
                }
                catch (Exception ex)
                {
                    Ps.MsgErro = ex.Message;
                }
            }
        }

        public IEnumerable<Pessoa> GetAllPessoas()
        {
            DatabaseContext Contexto = new DatabaseContext();
            return Contexto.Pessoas;
        }

        public void RemoverPessoa(int PessoaId)
        {
            using (DatabaseContext Contexto = new DatabaseContext())
            {
                Pessoa Ps = new Pessoa() { PessoaId = PessoaId };

                Contexto.Pessoas.Attach(Ps);

                Contexto.Pessoas.Remove(Ps);

                Contexto.SaveChanges();
            }
        }

    }
}
