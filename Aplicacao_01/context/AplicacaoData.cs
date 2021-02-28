using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using System.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Aplicacao_01.Models;

namespace Aplicacao_01.context
{
     public class AplicacaoData : DbContext
    {
        public AplicacaoData(DbContextOptions<AplicacaoData> options) : base(options)
        {
            
        }
        public DbSet<Formacao> Formacao{ get; set;}
        public DbSet<Curso> Curso{ get; set;}
       
    }
}
