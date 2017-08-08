using System.ComponentModel.DataAnnotations;
namespace projLoja.MVC.ViewModels
{
    public class VariacaoViewModel
    {
        [Key]
        public int VariacaoId { get; set; }

        public string Nome { get; set; }
    }
}