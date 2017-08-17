using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjLoja.Domain.Entities
{
    public class VendaItem
    {
        [Key]
        public int VendaItemId { get; set; }

        public int FormaPagamento { get; set; }

        public int StatusPagamento { get; set; }

        [Index("IX_VendaItemUsuarioId")]
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

        public decimal Valor { get; set; }

        public DateTime Data { get; set; }

        public int CondicaoPagamento { get; set; }

        [Index("IX_VendaItemProdutoId")]
        public int ProdutoId { get; set; }
        public Produto Produto { get; set; }

        [Index("IX_VendaItemServicoId")]
        public int ServicoId { get; set; }
        public Servico Servico { get; set; }

        [Index("IX_VendaItemVendaId")]
        public int VendaId { get; set; }
        public Venda Venda { get; set; }
    }
}
