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
    [Table("Pessoas")]
    public class Pessoa
    {
        [Key]
        public int PessoaId { get; set; }
        public string Name { get; set; }
        public string Telefone  { get; set; }
        public string Funcao { get; set; }

        [ForeignKey("Endereco")]
        public int? EnderecoId { get; set; }
        [ForeignKey("Celula")]
        public int CelulaId { get; set; }


        public virtual Endereco Endereco { get; set; }


        public virtual Celula Celula { get; set; }

        [NotMapped]
        public string MsgErro { get; set; }

    }
}