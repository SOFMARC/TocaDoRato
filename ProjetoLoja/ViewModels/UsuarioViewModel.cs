using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoLoja.ViewModels
{
    [Table("Usuarios")]
    public class UsuarioViewModel
    {
        [Key]  
        public int UsuarioId { get; set; }

    
        [MaxLength(150, ErrorMessage = "Máximo {0} Caracteres")]
        [MinLength(2, ErrorMessage = "Minimo de {0} Caracteres")]
        public string Nome { get; set; }

   
        [MaxLength(150, ErrorMessage = "Máximo {0} Caracteres")]
        [MinLength(2, ErrorMessage = "Minimo de {0} Caracteres")]
        public string SobreNome { get; set; }

    
        [MaxLength(100, ErrorMessage = "Máximo {0} Caracteres")]
        [EmailAddress(ErrorMessage = "Preencha um email válido")]
        [DisplayName("E-mail")]
        public string Email { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }

        public bool Ativo { get; set; }

        [Display(Name = "Login")]
        [Required(ErrorMessage = "Informe o nome do usuário", AllowEmptyStrings = false)]
        public string Login { get; set; }
        [Required(ErrorMessage = "Informe a senha do usuário", AllowEmptyStrings = false)]
        [DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
        public string Senha { get; set; }
    }
}