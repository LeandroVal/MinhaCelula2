using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaCelula.Model
{
    [Table("Cultos")]
    public class Culto
    {
        [Key]
        public int CultoId { get; set; }
        public DateTime Data { get; set; }
        public int CelulaId { get; set; }

        [ForeignKey("CelulaId")]
        public virtual Celula Celula { get; set; }
    }
}
