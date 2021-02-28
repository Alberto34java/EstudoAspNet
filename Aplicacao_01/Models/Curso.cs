using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aplicacao_01.Models
{
    public class Curso
    {
        [KeyAttribute]
        public int Id { get; set; }

        [RequiredAttribute(ErrorMessage="*")]
        public string Nome { get; set; }
           [RequiredAttribute(ErrorMessage="*")]
          [StringLength(200,MinimumLength=50, ErrorMessage="Preencha a Descrição")]
        public string Descricao { get; set; }
          [RequiredAttribute(ErrorMessage="*")]
          [StringLength(10,MinimumLength=6, ErrorMessage="Preencha a Duracao")]
        public string Duracao { get; set; }

        [RequiredAttribute(ErrorMessage="*")]
        public int FormacaoId { get; set; }

        public Formacao Formacao{ get; set;}
        
        /*O Curso pertence a uma formacao
        licenciatura,baxharelado,pos graduacao,mestrado..
         */
        
        
        
        
    } 
    
    
}
