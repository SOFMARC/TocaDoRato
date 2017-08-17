using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjLoja.Domain.Entities
{
    public class Usuario
    {  
        [Key]
        public int UsuarioId { get; set; }
    
        public string Nome { get; set; }
    
        public string SobreNome { get; set; }
     
        public string Email { get; set; }
    
        public DateTime DataCadastro { get; set; }

        public string Senha { get; set; }

        public string Login { get; set; }

        public bool Ativo { get; set; }
    }
}
