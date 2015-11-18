using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace ProyectoFinal.MiBD
{
    public class ProyectoFinal : DbContext
    {

        public DbSet<Clientes> Cliente { get; set; } //<clase> cliente(tablas)
        public DbSet<DetallesPedido> Detalles { get; set; }
        public DbSet<Empleados> Empleado { get; set; }
        public DbSet<Pedidos> Pedido { get; set; }
    
    }
}
