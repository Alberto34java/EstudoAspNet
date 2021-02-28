using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aplicacao_01.Models
{
    public class Formacao
    {
        [KeyAttribute]
        public int Id{ get; set;}
        [Required(ErrorMessage="*")]
        public string Nome { get; set;}
    }
}
