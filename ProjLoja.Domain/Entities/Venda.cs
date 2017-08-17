using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjLoja.Domain.Entities
{
    public class Venda
    {
        [Key]
        public int VendaId { get; set; }

        public decimal Valor { get; set; }

        public decimal Desconto { get; set; }

        public decimal ValorTotal { get; set; }

        public int Quantidade { get; set; }

        public virtual IEnumerable<VendaItem> VendaItens { get; set; }

        public int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
