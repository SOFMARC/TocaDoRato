using System;
using System.Collections.Generic;

namespace ProjLoja.Domain.Entities
{
    public class Servico
    {
        public int ServicoId { get; set; }
      
        public string Descricao { get; set; }
      
        public decimal Valor { get; set; }
     
        public decimal DescontoAtivo { get; set; }

        public bool Ativo { get; set; }
    }
}
