using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinhaCelula.Model;
using MinhaCelula.DAL.DAL;

namespace MinhaCelula.BLL
{

        public class PessoaBLL
        {
            public void CriarAlterarUsuario(Pessoa Ps)
            {
                new PessoaDAL().CriarAlterarPessoa(Ps);
            }

            public IEnumerable<Pessoa> GetAllPessoas()
            {
                return new PessoaDAL().GetAllPessoas();
            }

            public string RemovePessoa (int PessoaId)
            {
                string success = string.Empty;

                try
                {
                    new PessoaDAL().RemoverPessoa(PessoaId);
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
