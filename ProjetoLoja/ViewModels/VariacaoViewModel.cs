using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoLoja.ViewModels
{
    [Table("Variacao")]
    public class VariacaoViewModel
    {
        [Key]     
        public int VariacaoId { get; set; }

        [Required()]
        [MaxLength(100)]
        public string Descricao { get; set; }

        [Required()]
        public bool Ativo { get; set; }

        public int Tipo { get; set; }

        public virtual IEnumerable<ProdutoViewModel> Produtos { get; set; }

    }
}