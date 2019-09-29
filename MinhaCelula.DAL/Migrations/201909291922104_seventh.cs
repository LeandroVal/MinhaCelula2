namespace MinhaCelula.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seventh : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Pessoas", "EnderecoId", "dbo.Enderecos");
            DropIndex("dbo.Pessoas", new[] { "EnderecoId" });
            AlterColumn("dbo.Pessoas", "EnderecoId", c => c.Int());
            CreateIndex("dbo.Pessoas", "EnderecoId");
            AddForeignKey("dbo.Pessoas", "EnderecoId", "dbo.Enderecos", "EnderecoId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pessoas", "EnderecoId", "dbo.Enderecos");
            DropIndex("dbo.Pessoas", new[] { "EnderecoId" });
            AlterColumn("dbo.Pessoas", "EnderecoId", c => c.Int(nullable: false));
            CreateIndex("dbo.Pessoas", "EnderecoId");
            AddForeignKey("dbo.Pessoas", "EnderecoId", "dbo.Enderecos", "EnderecoId", cascadeDelete: true);
        }
    }
}
