using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal.MiBD
{
   public class Productos
    {
        [Key]
        public int idProducto { get; set; }
        public string nomProducto { get; set; }
        
    }
}
