namespace MinhaCelula.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sixth : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Enderecos",
                c => new
                    {
                        EnderecoId = c.Int(nullable: false, identity: true),
                        Logradouro = c.String(),
                        numero = c.String(),
                        bairro = c.String(),
                        cep = c.String(),
                        cidade = c.String(),
                    })
                .PrimaryKey(t => t.EnderecoId);
            
            CreateTable(
                "dbo.Pessoas",
                c => new
                    {
                        PessoaId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Telefone = c.String(),
                        Funcao = c.String(),
                        EnderecoId = c.Int(nullable: false),
                        CelulaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PessoaId)
                .ForeignKey("dbo.Celulas", t => t.CelulaId, cascadeDelete: true)
                .ForeignKey("dbo.Enderecos", t => t.EnderecoId, cascadeDelete: true)
                .Index(t => t.EnderecoId)
                .Index(t => t.CelulaId);
            
            AddColumn("dbo.Usuarios", "PessoaId", c => c.Int(nullable: false));
            CreateIndex("dbo.Usuarios", "PessoaId");
            AddForeignKey("dbo.Usuarios", "PessoaId", "dbo.Pessoas", "PessoaId", cascadeDelete: true);
            DropColumn("dbo.Usuarios", "UserName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Usuarios", "UserName", c => c.String());
            DropForeignKey("dbo.Usuarios", "PessoaId", "dbo.Pessoas");
            DropForeignKey("dbo.Pessoas", "EnderecoId", "dbo.Enderecos");
            DropForeignKey("dbo.Pessoas", "CelulaId", "dbo.Celulas");
            DropIndex("dbo.Usuarios", new[] { "PessoaId" });
            DropIndex("dbo.Pessoas", new[] { "CelulaId" });
            DropIndex("dbo.Pessoas", new[] { "EnderecoId" });
            DropColumn("dbo.Usuarios", "PessoaId");
            DropTable("dbo.Pessoas");
            DropTable("dbo.Enderecos");
        }
    }
}
