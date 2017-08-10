using System;
using System.Collections.Generic;

namespace ProjLoja.Domain.Entities
{
    public class Caixa
    {
        [Key]
        public int CaixaId { get; set; }

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
