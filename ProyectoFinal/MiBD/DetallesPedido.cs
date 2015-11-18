using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal.MiBD
{
  public class DetallesPedido
    {
      [Key]
        public int idPedido { get; set; }
        public int idProducto { get; set; }
        public int precio { get; set; }
        public int cantidad { get; set; }
    }
}
