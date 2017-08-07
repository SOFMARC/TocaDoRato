﻿using ProjLoja.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjLoja.Infra.Data.EntityConfig
{
    public class ProdutoConfiguration : EntityTypeConfiguration<Produto>
    {
        public ProdutoConfiguration()
        {
            HasKey(c => c.Id);
            Property(c => c.Nome)
                .IsRequired()
                .HasMaxLength(250);

            Property(c => c.Valor)
                    .IsRequired();  

        }
    }
}
