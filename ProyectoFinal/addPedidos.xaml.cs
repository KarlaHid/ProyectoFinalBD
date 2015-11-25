using ProyectoFinal.MiBD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ProyectoFinal
{
    /// <summary>
    /// Interaction logic for addPedidos.xaml
    /// </summary>
    public partial class addPedidos : Window
    {
        public addPedidos()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //instanciar bd
            ProyectoFinal.MiBD.ProyectoFinal db = new ProyectoFinal.MiBD.ProyectoFinal();

            Pedidos ped = new Pedidos();

            ped.idPedido = int.Parse(tp1.Text);
            ped.idCliente = int.Parse(tp2.Text);
            ped.idEmpleado = int.Parse(tp3.Text);
            ped.fechaPedido = tp4.Text;


            db.Pedido.Add(ped);
            db.SaveChanges();
            MessageBox.Show("Datos correctamente guardados");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //ProyectoFinal.MiBD.Clientes db = new ProyectoFinal.MiBD.Clientes();
            ProyectoFinal.MiBD.ProyectoFinal db = new ProyectoFinal.MiBD.ProyectoFinal();

            int id = int.Parse(tp1.Text);
            var ped = db.Pedido.SingleOrDefault(x => x.idPedido == id);
            //where x.id == id
            //select x;
            if (ped != null)
            {
                db.Pedido.Remove(ped);

                db.SaveChanges();
                MessageBox.Show("Datos correctamente eliminados");
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MainWindow ob = new MainWindow();
            ob.Show();
            this.Close();
        }
    }
}
