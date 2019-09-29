namespace MinhaCelula.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fifth : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Celulas", "Dia", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Celulas", "Dia", c => c.String());
        }
    }
}
