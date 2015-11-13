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

        public DbSet<Persona> Personas { get; set; } //<clase> Empleados(tablas)
    }
}
