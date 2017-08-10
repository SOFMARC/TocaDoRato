using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjLoja.Domain.Entities
{
    public class Variacao
    {
        public int Id { get; set; }

        public string Descricao { get; set; }

        public bool Ativo { get; set; }

        public int Tipo { get; set; }

        public virtual ICollection<Autor> Autores { get; set; }

    }
}
