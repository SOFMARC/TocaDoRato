using ProjLoja.Domain.Entities;
using ProjLoja.Infra.Data.EntityConfig;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjLoja.Infra.Data.Contexto
{
    public class ProjModelContext : DbContext
    {
        public ProjModelContext()
            : base("ProjLojaLocal")
        {
        }
        public DbSet<Cliente> Cliente { get; set; }

        public DbSet<Produto> Produtos { get; set; }

        public DbSet<Variacao> Variacoes { get; set; }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;
                }
                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataCadastro").IsModified = false;
                }
            }
            return base.SaveChanges();
        }

    }
}
