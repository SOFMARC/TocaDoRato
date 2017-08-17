using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjLoja.Domain.Entities
{
    public class Produto
    {
    
        [Key]
        public int ProdutoId { get; set; }
     
        public string Descricao { get; set; }

        public decimal Valor { get; set; }
   
        public decimal DescontoAtivo { get; set; }

        public virtual IEnumerable<Variacao> Variacoes { get; set; }

        public bool Ativo { get; set; }

        public int TipoProdutoId { get; set; }
       
        public virtual TipoProduto TipoProduto { get; set; }
    }
}
