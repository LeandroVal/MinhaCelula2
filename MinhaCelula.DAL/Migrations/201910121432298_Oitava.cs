namespace MinhaCelula.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Oitava : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cultos",
                c => new
                    {
                        CultoId = c.Int(nullable: false, identity: true),
                        Data = c.DateTime(nullable: false),
                        CelulaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CultoId)
                .ForeignKey("dbo.Celulas", t => t.CelulaId, cascadeDelete: true)
                .Index(t => t.CelulaId);
            
            CreateTable(
                "dbo.Presencas",
                c => new
                    {
                        PresencaId = c.Int(nullable: false, identity: true),
                        PessoaId = c.Int(),
                        CultoId = c.Int(),
                    })
                .PrimaryKey(t => t.PresencaId)
                .ForeignKey("dbo.Cultos", t => t.CultoId)
                .ForeignKey("dbo.Pessoas", t => t.PessoaId)
                .Index(t => t.PessoaId)
                .Index(t => t.CultoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Presencas", "PessoaId", "dbo.Pessoas");
            DropForeignKey("dbo.Presencas", "CultoId", "dbo.Cultos");
            DropForeignKey("dbo.Cultos", "CelulaId", "dbo.Celulas");
            DropIndex("dbo.Presencas", new[] { "CultoId" });
            DropIndex("dbo.Presencas", new[] { "PessoaId" });
            DropIndex("dbo.Cultos", new[] { "CelulaId" });
            DropTable("dbo.Presencas");
            DropTable("dbo.Cultos");
        }
    }
}
