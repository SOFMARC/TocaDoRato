using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjLoja.Domain.Entities
{

    public class TipoProduto
    {
        public int TipoId { get; set; }
    
        public string Descricao { get; set; }

        public ICollection<Produto> Produtos { get; set; }
    }
}
