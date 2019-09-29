using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinhaCelula.Model;
using MinhaCelula.DAL.DAL;
using System.Data.Entity.Migrations;

namespace MinhaCelula.DAL.DAL
{
    public class EnderecoDAL
    {
        public void NovoEndereco(Endereco En)
        {
            using (DatabaseContext contexto = new DatabaseContext())
            {

                try
                {
                    contexto.Enderecos.Add(En);
                    contexto.SaveChanges();
                }
                catch (Exception ex)
                {
                    En.MsgErro = ex.Message;
                }
            }
        }

        public void CriarAlterarEndereco(Endereco En)
        {
            using (DatabaseContext contexto = new DatabaseContext())
            {


                try
                {
                    contexto.Enderecos.AddOrUpdate(En);
                    contexto.SaveChanges();
                }
                catch (Exception ex)
                {
                    En.MsgErro = ex.Message;
                }
            }
        }

        public IEnumerable<Endereco> GetAllEnderecos()
        {
            DatabaseContext Contexto = new DatabaseContext();
            return Contexto.Enderecos;
        }

        public void RemoverEndereco(int EnderecoId)
        {
            using (DatabaseContext Contexto = new DatabaseContext())
            {
                Endereco En = new Endereco() { EnderecoId = EnderecoId };

                Contexto.Enderecos.Attach(En);

                Contexto.Enderecos.Remove(En);

                Contexto.SaveChanges();
            }
        }
    }
}
