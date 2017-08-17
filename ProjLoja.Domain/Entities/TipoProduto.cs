using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjLoja.Domain.Entities
{

    public class TipoProduto
    {
        [Key]
        public int TipoId { get; set; }
    
        public string Descricao { get; set; }

        public ICollection<Produto> Produtos { get; set; }
    }
}
