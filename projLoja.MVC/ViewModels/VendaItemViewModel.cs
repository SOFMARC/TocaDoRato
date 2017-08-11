using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjLoja.MVC.ViewModels
{
    [Table("VendaItem")]
    public class VendaItemViewModel
    {
        [Key]
        public int VendaItemId { get; set; }

        public int FormaPagamento { get; set; }

        public int StatusPagamento { get; set; }

        public int UsuarioId { get; set; }
        public UsuarioViewModel Usuario { get; set; }

        [DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "99999999999999")]
        public decimal Valor { get; set; }

        [ScaffoldColumn(false)]
        public DateTime Data { get; set; }

        public int CondicaoPagamento { get; set; }

        public int ProdutoId { get; set; }
        public ProdutoViewModel Produto { get; set; }

        public int ServicoId { get; set; }
        public ServicoViewModel Servico { get; set; }

        public int VendaId { get; set; }
        public VendaViewModel Venda { get; set; }


    }
}