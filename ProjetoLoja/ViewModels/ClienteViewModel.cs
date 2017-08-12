using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoLoja.ViewModels
{
    [Table("Cliente")]
    public class ClienteViewModel
    {
        [Key]
        public int ClienteId { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome")]
        [MaxLength(150, ErrorMessage = "Máximo {0} Caracteres")]
        [MinLength(2, ErrorMessage = "Minimo de {0} Caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome")]
        [MaxLength(150, ErrorMessage = "Máximo {0} Caracteres")]
        [MinLength(2, ErrorMessage = "Minimo de {0} Caracteres")]
        public string SobreNome { get; set; }

        [Required(ErrorMessage = "Preencha o campo e-mail")]
        [MaxLength(100, ErrorMessage = "Máximo {0} Caracteres")]
        [EmailAddress(ErrorMessage = "Preencha um email válido")]
        [DisplayName("E-mail")]
        public string Email { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }



        public bool Ativo { get; set; }
    }
}