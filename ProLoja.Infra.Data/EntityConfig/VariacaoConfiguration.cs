using ProjLoja.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjLoja.Infra.Data.EntityConfig
{
    public class VariacaoConfiguration : EntityTypeConfiguration<Variacao>
    {
        public VariacaoConfiguration()
        {
            HasKey(c => c.VariacaoId);
            Property(c => c.Nome)
                .IsRequired()
                .HasMaxLength(250);         

        }
    }
}
