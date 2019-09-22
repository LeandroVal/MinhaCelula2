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
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        public int UsuarioId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int PessoaId { get; set; }
        [ForeignKey("PessoaId")]
        public virtual Pessoa UsuarioPessoa { get; set; }

    }
}
