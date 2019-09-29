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
        public int EnderecoId { get; set; }
        public int CelulaId { get; set; }

        [ForeignKey("EnderecoId")]
        public virtual Endereco Endereco { get; set; }

        [ForeignKey("PessoaCelulaId")]
        public virtual Celula PessoaCelula { get; set; }

    }
}