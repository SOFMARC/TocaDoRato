using ProjLoja.Domain.Entities;
//using ProjetoLoja.Infra.Data.EntityConfig;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoLoja.Infra.Data.Migrations;
using System.Data.SQLite;

namespace ProjetoLoja.Infra.Data.Contexto
{
    public class ProjModelContext : DbContext
    {
        public ProjModelContext() : base("ProjLojaLocal")
        {
            
        }

        public DbSet<Cliente> Cliente { get; set; }

        public DbSet<Produto> Produtos { get; set; }

        public DbSet<Variacao> Variacoes { get; set; }

        public DbSet<Venda> Venda { get; set; }

        public DbSet<Caixa> Caixa { get; set; }

        public DbSet<Usuario> Usuario { get; set; }

        public DbSet<TipoProduto> TipoProduto { get; set; }

        public DbSet<VendaItem> VendaItem { get; set; }

        public DbSet<Servico> Servico { get; set; }

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

            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("Data") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("Data").CurrentValue = DateTime.Now;
                }
                if (entry.State == EntityState.Modified)
                {
                    entry.Property("Data").IsModified = false;
                }
            }
            return base.SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //Database.SetInitializer(new SqliteContextInitializer<ProjModelContext>(_dbPath, modelBuilder));
            base.OnModelCreating(modelBuilder);
        }
    }
}
