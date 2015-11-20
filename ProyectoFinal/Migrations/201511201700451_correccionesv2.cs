namespace ProyectoFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class correccionesv2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Clientes", "telCliente", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Clientes", "telCliente", c => c.Int(nullable: false));
        }
    }
}
