namespace MinhaCelula.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fourth : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Celulas",
                c => new
                    {
                        CelulaId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Dia = c.String(),
                        Horario = c.String(),
                        EnderecoId = c.Int(),
                    })
                .PrimaryKey(t => t.CelulaId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Celulas");
        }
    }
}
