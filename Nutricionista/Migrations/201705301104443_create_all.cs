namespace Nutricionista.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_all : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BlogItems",
                c => new
                    {
                        NumChave = c.Int(nullable: false, identity: true),
                        DesTitulo = c.String(nullable: false),
                        DesDescricao = c.String(nullable: false),
                        DesImagem = c.String(nullable: false),
                        DatCriacao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.NumChave);
            
            CreateTable(
                "dbo.Blogs",
                c => new
                    {
                        NumChave = c.Int(nullable: false, identity: true),
                        DesTitulo = c.String(nullable: false),
                        DesDescricao = c.String(nullable: false),
                        DesButtonCarregarMais = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.NumChave);
            
            CreateTable(
                "dbo.Clinicas",
                c => new
                    {
                        NumChave = c.Int(nullable: false, identity: true),
                        DesTitulo = c.String(nullable: false),
                        DesDescricao = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.NumChave);
            
            CreateTable(
                "dbo.ConfiguracaoSistemas",
                c => new
                    {
                        NumChave = c.Int(nullable: false, identity: true),
                        DesEndereco = c.String(nullable: false),
                        DesTelefone = c.String(nullable: false),
                        DesHorFuncionamento = c.String(nullable: false),
                        DesEmail = c.String(nullable: false),
                        DesDescricaoContato = c.String(),
                        DesLinkFacebook = c.String(),
                        DesLinkTwitter = c.String(),
                        DesLinkLinkedIn = c.String(),
                        DesLinkInstagram = c.String(),
                    })
                .PrimaryKey(t => t.NumChave);
            
            CreateTable(
                "dbo.Contatoes",
                c => new
                    {
                        NumChave = c.Int(nullable: false, identity: true),
                        DesNome = c.String(nullable: false),
                        DesEmail = c.Int(nullable: false),
                        DesAssunto = c.String(nullable: false),
                        DesMensagem = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.NumChave);
            
            CreateTable(
                "dbo.DepoimentoItems",
                c => new
                    {
                        NumChave = c.Int(nullable: false, identity: true),
                        DesNome = c.String(nullable: false),
                        DesIdade = c.Int(nullable: false),
                        DesDescricao = c.String(nullable: false),
                        DesImagem = c.Binary(nullable: false),
                    })
                .PrimaryKey(t => t.NumChave);
            
            CreateTable(
                "dbo.Depoimentoes",
                c => new
                    {
                        NumChave = c.Int(nullable: false, identity: true),
                        DesTitulo = c.String(nullable: false),
                        DesDescricao = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.NumChave);
            
            CreateTable(
                "dbo.Servicos",
                c => new
                    {
                        NumChave = c.Int(nullable: false, identity: true),
                        DesTitulo = c.String(nullable: false),
                        DesDescricao = c.String(nullable: false),
                        DesImagem = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.NumChave);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        NumChave = c.Int(nullable: false, identity: true),
                        DesNome = c.String(nullable: false),
                        DesEmail = c.String(nullable: false),
                        DesSenha = c.String(nullable: false),
                        TipPerfil = c.Int(nullable: false),
                        DatCadastro = c.DateTime(nullable: false),
                        FlgExcluido = c.Boolean(nullable: false),
                        FlgBloqueado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.NumChave);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Usuarios");
            DropTable("dbo.Servicos");
            DropTable("dbo.Depoimentoes");
            DropTable("dbo.DepoimentoItems");
            DropTable("dbo.Contatoes");
            DropTable("dbo.ConfiguracaoSistemas");
            DropTable("dbo.Clinicas");
            DropTable("dbo.Blogs");
            DropTable("dbo.BlogItems");
        }
    }
}
