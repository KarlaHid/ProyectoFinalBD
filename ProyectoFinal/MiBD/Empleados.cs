using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal.MiBD
{
   public class Empleados
    {
       [Key]
        public int idEmpleado { get; set; }
        public string nomEmpleado { get; set; }
      
    }
}
