using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MinhaCelula.Model;
using MinhaCelula.DAL.DAL;
using System.Threading.Tasks;

namespace MinhaCelula.BLL
{
    class EnderecoBLL
    {
        public void CriarAlterarEndereco(Endereco En)
        {
            new EnderecoBLL().CriarAlterarEndereco(En);
        }

        public IEnumerable<Endereco> GetAllEnderecos()
        {
            return new EnderecoBLL().GetAllEnderecos();
        }

        public string RemoveEndereco(int EnderecoId)
        {
            string success = string.Empty;

            try
            {
                new EnderecoDAL().RemoverEndereco(EnderecoId);
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
