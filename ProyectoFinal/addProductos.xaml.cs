﻿using ProyectoFinal.MiBD;
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
    /// Interaction logic for addProductos.xaml
    /// </summary>
    public partial class addProductos : Window
    {
        public addProductos()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ProyectoFinal.MiBD.ProyectoFinal db = new ProyectoFinal.MiBD.ProyectoFinal();
            Productos pro = new Productos();

            pro.idProducto = int.Parse(pro1.Text);
            pro.nomProducto = pro2.Text;
         

            db.Producto.Add(pro);
            db.SaveChanges();
            MessageBox.Show("Datos correctamente guardados");        
        }
    }
}
