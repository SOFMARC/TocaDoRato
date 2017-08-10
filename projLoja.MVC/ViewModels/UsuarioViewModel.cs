using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace projLoja.MVC.ViewModels
{
    [Table("Usuarios")]
    public class ClienteViewModel
    {
        [Key]  
        public int UsuarioId { get; set; }

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

        [Required(ErrorMessage = "Preencha o campo Senha")]
        [MaxLength(10, ErrorMessage = "Máximo {0} Caracteres")]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Preencha o campo Login")]
        [MaxLength(50, ErrorMessage = "Máximo {0} Caracteres")]
        public string Login { get; set; }

        public bool Ativo { get; set; }
    }
}