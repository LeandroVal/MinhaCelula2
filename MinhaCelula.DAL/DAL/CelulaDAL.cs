using MinhaCelula.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaCelula.DAL.DAL
{
    public class CelulaDAL
    {
        public void NovaCelula(Celula Cl)
        {
            using (DatabaseContext contexto = new DatabaseContext())
            {
                try
                {
                    contexto.Celulas.Add(Cl);
                    contexto.SaveChanges();
                }
                catch (Exception ex)
                {
                    Cl.MsgErro = ex.Message;
                }
            }
        }

        public void CriarAlterarCelula(Celula Cl)
        {
            using (DatabaseContext contexto = new DatabaseContext())
            {
                try
                {
                    contexto.Celulas.AddOrUpdate(Cl);
                    contexto.SaveChanges();
                }
                catch (Exception ex)
                {
                    Cl.MsgErro = ex.Message;
                }
            }
        }

        public IEnumerable<Celula> GetAllCelulas()
        {
            DatabaseContext Contexto = new DatabaseContext();
            return Contexto.Celulas;
        }

        public void RemoverCelula(int CelulaId)
        {
            using (DatabaseContext Contexto = new DatabaseContext())
            {
                Celula Cl = new Celula() { CelulaId = CelulaId };

                Contexto.Celulas.Attach(Cl);

                Contexto.Celulas.Remove(Cl);

                Contexto.SaveChanges();
            }
        }
    }
}
