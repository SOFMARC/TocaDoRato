using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjLoja.MVC.ViewModels
{
    [Table("TipoProduto")]
    public class TipoProdutoViewModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TipoId { get; set; }

        [Required()]
        [MaxLength(100)]
        public string Descricao { get; set; }

        [ForeignKey("TipoProdutoId")]
        public ICollection<ProdutoViewModel> Produtos { get; set; }
    }
}