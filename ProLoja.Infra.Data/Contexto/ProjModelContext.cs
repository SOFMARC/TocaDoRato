using ProjLoja.Domain.Entities;
using System.Data.Entity;


namespace ProjLoja.Infra.Data.Contexto
{
    public class ProjModelContext : DbContext
    {
        public ProjModelContext() : base("ProjLoja")
        {
        }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Variacao> Variacoes { get; set; }
      
    }
}
