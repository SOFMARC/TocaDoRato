using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Reflection;

namespace ProjLoja.Domain.Entities
{
    public class Caixa
    {     
        [Key]
        public int CaixaId { get; set; }

        [Index("IX_CaixaUsuarioId")]
        public int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
   
        public decimal ValorAbertura { get; set; }
    
        public decimal ValorFechamento { get; set; }
      
        public decimal Sangria { get; set; }
      
        public decimal Reforco { get; set; }
    
        public DateTime Data { get; set; }

        public bool Ativo { get; set; }
    }
}
