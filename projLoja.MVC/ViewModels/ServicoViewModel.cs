using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjLoja.MVC.ViewModels
{
    [Table("Servico")]
    public class ServicoViewModel
    {
        [Key]
        public int ServicoId { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome")]
        [MaxLength(250, ErrorMessage = "Máximo {0} Caracteres")]
        [MinLength(2, ErrorMessage = "Minimo de {0} Caracteres")]
        [Display(Name = "Nome")]
        public string Descricao { get; set; }

        [DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "99999999999999")]
        [Required(ErrorMessage = "Preencha um valor")]
        public decimal Valor { get; set; }

        [DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "99999999999999")]
        [Display(Name = "Desconto Ativo")]
        public decimal DescontoAtivo { get; set; }  

        public bool Ativo { get; set; }

    }
}