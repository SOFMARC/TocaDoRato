using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoLoja.ViewModels
{
    [Table("Venda")]
    public class VendaViewModel
    {
        [Key]
        public int VendaId { get; set; }

        [DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "99999999999999")]
        [Required(ErrorMessage = "Preencha um valor")]
        public decimal Valor { get; set; }

        [DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "99999999999999")]
        public decimal Desconto { get; set; }

        [DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "99999999999999")]
        public decimal ValorTotal { get; set; }

        [DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "99999999999999")]
        public int Quantidade { get; set; }

        public virtual IEnumerable<VendaItemViewModel> VendaItens { get; set; }

        public int UsuarioId { get; set; }
        public virtual UsuarioViewModel Usuario { get; set; }

    }
}