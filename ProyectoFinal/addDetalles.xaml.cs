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
using System.Text.RegularExpressions;
using ProyectoFinal.MiBD;

namespace ProyectoFinal
{
    /// <summary>
    /// Interaction logic for addDetalles.xaml
    /// </summary>
    public partial class addDetalles : Window
    {
        public addDetalles()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //instanciar bd
            ProyectoFinal.MiBD.ProyectoFinal db = new ProyectoFinal.MiBD.ProyectoFinal();

            DetallesPedido detalles = new DetallesPedido();

            detalles.idPedido = int.Parse(txtd1.Text);
            detalles.idProducto = int.Parse(txtd2.Text);
            detalles.precio = int.Parse(txtd3.Text);
            detalles.cantidad = int.Parse(txtd4.Text);


            db.Detalles.Add(detalles);
            db.SaveChanges();
            MessageBox.Show("Datos correctamente guardados");
        }

       
           
        }

       

        
    }

