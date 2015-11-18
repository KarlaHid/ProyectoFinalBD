using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal.MiBD
{
   public class Pedidos
    {
       [Key]
        public int idPedido { get; set; }
        public int idCliente { get; set; }
        public int idEmpleado { get; set; }
        public string fechaPedido { get; set; }
    }
}
