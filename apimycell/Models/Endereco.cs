using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace apimycell.Models
{[Table ("Enderecos")]
    public class Endereco
    {
            [Key]
            public int EnderecoId { get; set; }
            public string Logradouro { get; set; }
            public string numero { get; set; }
            public string bairro { get; set; }
            public string cep { get; set; }
            public string cidade { get; set; }

      
    }
}