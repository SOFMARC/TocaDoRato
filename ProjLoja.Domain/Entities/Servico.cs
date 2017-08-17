using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjLoja.Domain.Entities
{
    public class Servico
    {
        [Key]
        public int ServicoId { get; set; }
      
        public string Descricao { get; set; }
      
        public decimal Valor { get; set; }
     
        public decimal DescontoAtivo { get; set; }

        public bool Ativo { get; set; }
    }
}
