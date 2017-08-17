namespace ProjetoLoja.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Caixa",
                c => new
                    {
                        CaixaId = c.Int(nullable: false, identity: true),
                        UsuarioId = c.Int(nullable: false),
                        ValorAbertura = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ValorFechamento = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Sangria = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Reforco = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Data = c.DateTime(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.CaixaId)
                .ForeignKey("dbo.Usuario", t => t.UsuarioId, cascadeDelete: true)
                .Index(t => t.UsuarioId, name: "IX_CaixaUsuarioId");
            
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
                "dbo.Servico",
                c => new
                    {
                        ServicoId = c.Int(nullable: false, identity: true),
                        Descricao = c.String(maxLength: 2147483647),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DescontoAtivo = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Ativo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ServicoId);
            
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
                .Index(t => t.UsuarioId, name: "IX_VendaUsuarioId");
            
            CreateTable(
                "dbo.VendaItem",
                c => new
                    {
                        VendaItemId = c.Int(nullable: false, identity: true),
                        FormaPagamento = c.Int(nullable: false),
                        StatusPagamento = c.Int(nullable: false),
                        UsuarioId = c.Int(nullable: false),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Data = c.DateTime(nullable: false),
                        CondicaoPagamento = c.Int(nullable: false),
                        ProdutoId = c.Int(nullable: false),
                        ServicoId = c.Int(nullable: false),
                        VendaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.VendaItemId)
                .ForeignKey("dbo.Produto", t => t.ProdutoId, cascadeDelete: true)
                .ForeignKey("dbo.Servico", t => t.ServicoId, cascadeDelete: true)
                .ForeignKey("dbo.Usuario", t => t.UsuarioId, cascadeDelete: true)
                .ForeignKey("dbo.Venda", t => t.VendaId, cascadeDelete: true)
                .Index(t => t.UsuarioId, name: "IX_VendaItemUsuarioId")
                .Index(t => t.ProdutoId, name: "IX_VendaItemProdutoId")
                .Index(t => t.ServicoId, name: "IX_VendaItemServicoId")
                .Index(t => t.VendaId, name: "IX_VendaItemVendaId");
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.VendaItem", "VendaId", "dbo.Venda");
            DropForeignKey("dbo.VendaItem", "UsuarioId", "dbo.Usuario");
            DropForeignKey("dbo.VendaItem", "ServicoId", "dbo.Servico");
            DropForeignKey("dbo.VendaItem", "ProdutoId", "dbo.Produto");
            DropForeignKey("dbo.Venda", "UsuarioId", "dbo.Usuario");
            DropForeignKey("dbo.Produto", "TipoProduto_TipoId", "dbo.TipoProduto");
            DropForeignKey("dbo.Caixa", "UsuarioId", "dbo.Usuario");
            DropIndex("dbo.VendaItem", "IX_VendaItemVendaId");
            DropIndex("dbo.VendaItem", "IX_VendaItemServicoId");
            DropIndex("dbo.VendaItem", "IX_VendaItemProdutoId");
            DropIndex("dbo.VendaItem", "IX_VendaItemUsuarioId");
            DropIndex("dbo.Venda", "IX_VendaUsuarioId");
            DropIndex("dbo.Produto", new[] { "TipoProduto_TipoId" });
            DropIndex("dbo.Caixa", "IX_CaixaUsuarioId");
            DropTable("dbo.VendaItem");
            DropTable("dbo.Venda");
            DropTable("dbo.Variacao");
            DropTable("dbo.Servico");
            DropTable("dbo.TipoProduto");
            DropTable("dbo.Produto");
            DropTable("dbo.Cliente");
            DropTable("dbo.Usuario");
            DropTable("dbo.Caixa");
        }
    }
}
