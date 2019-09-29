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
    [Table("Celulas")]
    public class Celula
    {
        [Key]
        public int CelulaId { get; set; }
        public string Name { get; set; }
        public string Dia { get; set; }
        public string Horario { get; set; }
        public int EnderecoId { get; set; }

        [ForeignKey("EnderecoId")]
        public virtual Endereco CelulaEndereco { get; set; }
        
    }
}