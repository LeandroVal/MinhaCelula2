using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaCelula.Model
{
    [Table("Presencas")]
    public class Presenca
    {
        [Key]
        public int PresencaId { get; set; }       
        public int? PessoaId { get; set; }
        public int? CultoId { get; set; }


        [ForeignKey("PessoaId")]
        public virtual Pessoa Pessoa { get; set; }
        [ForeignKey("CultoId")]
        public virtual Culto Culto { get; set; }
    }
}
