namespace ProyectoFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class correcciones : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Empleados", "sueldo", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Empleados", "sueldo");
        }
    }
}
