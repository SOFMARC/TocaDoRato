using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace projLoja.MVC.ViewModels
{
    [Table("Caixa")]
    public class CaixaViewModel
    {
        [Key]    
        public int CaixaId { get; set; }

        public int UsuarioId { get; set; }
        public virtual UsuarioViewModel Usuario { get; set; }        

        [DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "99999999999999")]
        [Required(ErrorMessage = "Preencha um valor")]
        public decimal ValorAbertura { get; set; }

        [DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "99999999999999")]
        public decimal ValorFechamento { get; set; }

        [DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "99999999999999")]
        public decimal Sangria { get; set; }

        [DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "99999999999999")]
        public decimal Reforco { get; set; }


        [ScaffoldColumn(false)]
        public DateTime Data { get; set; }

        public bool Ativo { get; set; }      

    }
}