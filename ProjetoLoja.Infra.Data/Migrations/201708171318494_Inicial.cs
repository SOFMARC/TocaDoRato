namespace ProjetoLoja.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cliente",
                c => new
                    {
                        ClienteId = c.Int(nullable: false, identity: true),
                        Nome = c.String(maxLength: 2147483647),
                        SobreNome = c.String(maxLength: 2147483647),
                        Email = c.String(maxLength: 2147483647),
                        DataCadastro = c.DateTime(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ClienteId);
            
            CreateTable(
                "dbo.Produto",
                c => new
                    {
                        ProdutoId = c.Int(nullable: false, identity: true),
                        Descricao = c.String(maxLength: 2147483647),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DescontoAtivo = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Ativo = c.Boolean(nullable: false),
                        TipoProdutoId = c.Int(nullable: false),
                        TipoProduto_TipoId = c.Int(),
                    })
                .PrimaryKey(t => t.ProdutoId)
                .ForeignKey("dbo.TipoProduto", t => t.TipoProduto_TipoId)
                .Index(t => t.TipoProduto_TipoId);
            
            CreateTable(
                "dbo.TipoProduto",
                c => new
                    {
                        TipoId = c.Int(nullable: false, identity: true),
                        Descricao = c.String(maxLength: 2147483647),
                    })
                .PrimaryKey(t => t.TipoId);
            
            CreateTable(
                "dbo.Usuario",
                c => new
                    {
                        UsuarioId = c.Int(nullable: false, identity: true),
                        Nome = c.String(maxLength: 2147483647),
                        SobreNome = c.String(maxLength: 2147483647),
                        Email = c.String(maxLength: 2147483647),
                        DataCadastro = c.DateTime(nullable: false),
                        Senha = c.String(maxLength: 2147483647),
                        Login = c.String(maxLength: 2147483647),
                        Ativo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.UsuarioId);
            
            CreateTable(
                "dbo.Variacao",
                c => new
                    {
                        VariacaoId = c.Int(nullable: false, identity: true),
                        Descricao = c.String(maxLength: 2147483647),
                        Ativo = c.Boolean(nullable: false),
                        Tipo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.VariacaoId);
            
            CreateTable(
                "dbo.Venda",
                c => new
                    {
                        VendaId = c.Int(nullable: false, identity: true),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Desconto = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ValorTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Quantidade = c.Int(nullable: false),
                        UsuarioId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.VendaId)
                .ForeignKey("dbo.Usuario", t => t.UsuarioId, cascadeDelete: true)
                .Index(t => t.UsuarioId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Venda", "UsuarioId", "dbo.Usuario");
            DropForeignKey("dbo.Produto", "TipoProduto_TipoId", "dbo.TipoProduto");
            DropIndex("dbo.Venda", new[] { "UsuarioId" });
            DropIndex("dbo.Produto", new[] { "TipoProduto_TipoId" });
            DropTable("dbo.Venda");
            DropTable("dbo.Variacao");
            DropTable("dbo.Usuario");
            DropTable("dbo.TipoProduto");
            DropTable("dbo.Produto");
            DropTable("dbo.Cliente");
        }
    }
}
