using MinhaCelula.DAL.DAL;
using MinhaCelula.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaCelula.BLL
{
    public class CelulaBLL
    {
        public void CriarAlterarCelula(Celula Cl)
        {
            new CelulaDAL().CriarAlterarCelula(Cl);
        }

        public IEnumerable<Celula> GetAllCelula()
        {
            return new CelulaDAL().GetAllCelulas();
        }

        public string RemoverCelula(int CelulaId)
        {
            string success = string.Empty;

            try
            {
                new CelulaDAL().RemoverCelula(CelulaId);
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
