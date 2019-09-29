using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinhaCelula.Model;

namespace MinhaCelula.DAL.DAL
{
    public class FrequenciaDAL
    {
        public void NovaFrequencia( Frequencia Fq)
        {
            using (DatabaseContext contexto = new DatabaseContext())
            {

                //try
                //{
                //    contexto.Frequencias.Add(Fq);
                //    contexto.SaveChanges();
                //}
                //catch (Exception ex)
                //{
                //    Fq.MsgErro = ex.Message;
                //}
            }
        }

        public void CriarAlterarFrequencia(Frequencia Fq)
        {
            using (DatabaseContext contexto = new DatabaseContext())
            {


                //try
                //{
                //    contexto.Frequencias.AddOrUpdate(Fq);
                //    contexto.SaveChanges();
                //}
                //catch (Exception ex)
                //{
                //    Fq.MsgErro = ex.Message;
                //}
            }
        }

        //public IEnumerable<Frequencia> GetAllFrequencia()
        //{
        //    DatabaseContext Contexto = new DatabaseContext();
        //    return Contexto.Frequencias;
        //}

        public void RemoverFrequencia(int FrequenciaId)
        {
            using (DatabaseContext Contexto = new DatabaseContext())
            {
                Frequencia Fq = new Frequencia() { FrequenciaId = FrequenciaId };

                //Contexto.Frequencias.Attach(Fq);

                //Contexto.Frequencias.Remove(Fq);

                Contexto.SaveChanges();
            }
        }
    }
}
