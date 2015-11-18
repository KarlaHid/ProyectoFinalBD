namespace ProyectoFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class creacionTablas : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        idCliente = c.Int(nullable: false, identity: true),
                        nomCliente = c.String(),
                        telCliente = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.idCliente);
            
            CreateTable(
                "dbo.DetallesPedidoes",
                c => new
                    {
                        idPedido = c.Int(nullable: false, identity: true),
                        idProducto = c.Int(nullable: false),
                        precio = c.Int(nullable: false),
                        cantidad = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.idPedido);
            
            CreateTable(
                "dbo.Empleados",
                c => new
                    {
                        idEmpleado = c.Int(nullable: false, identity: true),
                        nomEmpleado = c.String(),
                    })
                .PrimaryKey(t => t.idEmpleado);
            
            CreateTable(
                "dbo.Pedidos",
                c => new
                    {
                        idPedido = c.Int(nullable: false, identity: true),
                        idCliente = c.Int(nullable: false),
                        idEmpleado = c.Int(nullable: false),
                        fechaPedido = c.String(),
                    })
                .PrimaryKey(t => t.idPedido);
            
            DropTable("dbo.Personas");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Personas",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            DropTable("dbo.Pedidos");
            DropTable("dbo.Empleados");
            DropTable("dbo.DetallesPedidoes");
            DropTable("dbo.Clientes");
        }
    }
}
