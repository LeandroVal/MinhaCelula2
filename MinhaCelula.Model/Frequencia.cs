using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinhaCelula.Model;

namespace MinhaCelula.Model
{
    [Table("Frequencias")]
    public class Frequencia
    {
        [Key]
        public int FrequenciaId { get; set; }
        public DateTime FrequenciaData { get; set; }
        public bool PresencaPessoa { get; set; }
        public int PessoaId { get; set; }
        public int CelulaId { get; set; }

        [ForeignKey("PessoaId")]
        public virtual Pessoa FrequenciaPessoa { get; set; }

        [ForeignKey("CelulaId")]
        public virtual Celula FrequenciaCelula { get; set; }



    }
}