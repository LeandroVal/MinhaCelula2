namespace MinhaCelula.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Tirth : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Usuarios");
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        UsuarioId = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Email = c.String(),
                        Password = c.String(),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UsuarioId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Usuarios");
        }
    }
}
