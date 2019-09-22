namespace MinhaCelula.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Second : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Usuarios", "Status", c => c.Int(nullable: false));
            DropColumn("dbo.Usuarios", "FirstAccess");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Usuarios", "FirstAccess", c => c.Boolean(nullable: false));
            DropColumn("dbo.Usuarios", "Status");
        }
    }
}
