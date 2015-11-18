using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal.MiBD
{
   public class Clientes
    {
        [Key]
        public int idCliente { get; set; }
        public string nomCliente { get; set; }
        public int telCliente { get; set; }
    }
}
