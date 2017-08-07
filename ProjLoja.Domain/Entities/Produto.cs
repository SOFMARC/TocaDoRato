using System;
using System.Collections.Generic;

namespace ProjLoja.Domain.Entities
{
    public class Produto
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public virtual IEnumerable<Variacao> Variacoes { get; set; }

        public decimal Valor { get; set; }

        public bool Ativo { get; set; }
    }
}
