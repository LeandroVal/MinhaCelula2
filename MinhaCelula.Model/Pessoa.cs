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
        public string PessoaName { get; set; }
        public string PessoaTelefone  { get; set; }
        public string PessoaFuncao { get; set; }
        public int EnderecoId { get; set; }
        public int PessoaCelulaId { get; set; }

        [ForeignKey("EnderecoId")]
        public virtual Endereco PessoaEndereco { get; set; }

        [ForeignKey("PessoaCelulaId")]
        public virtual Celula PessoaCelula { get; set; }

    }
}