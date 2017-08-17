using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjLoja.Domain.Entities
{
    public class VendaItem
    {
        [Key]
        public int VendaItemId { get; set; }

        public int FormaPagamento { get; set; }

        public int StatusPagamento { get; set; }

        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

        public decimal Valor { get; set; }

        public DateTime Data { get; set; }

        public int CondicaoPagamento { get; set; }

        public int ProdutoId { get; set; }
        public Produto Produto { get; set; }

        public int ServicoId { get; set; }
        public Servico Servico { get; set; }

        public int VendaId { get; set; }
        public Venda Venda { get; set; }
    }
}
