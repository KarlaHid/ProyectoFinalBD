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
using ProyectoFinal.MiBD;

namespace ProyectoFinal
{
    /// <summary>
    /// Interaction logic for addClientes.xaml
    /// </summary>
    public partial class addClientes : Window
    {
        public addClientes()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //instanciar bd
            ProyectoFinal.MiBD.ProyectoFinal db = new ProyectoFinal.MiBD.ProyectoFinal();

            Clientes client = new Clientes();
            client.nomCliente = txtnomC.Text;
            client.telCliente = txttelC.Text;


            db.Cliente.Add(client);
            db.SaveChanges();
        }
    }
}
