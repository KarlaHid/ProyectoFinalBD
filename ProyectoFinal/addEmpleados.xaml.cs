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
    /// Interaction logic for addEmpleados.xaml
    /// </summary>
    public partial class addEmpleados : Window
    {
        public addEmpleados()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //instanciar bd
            ProyectoFinal.MiBD.ProyectoFinal db = new ProyectoFinal.MiBD.ProyectoFinal();

            Empleados emp = new Empleados();

            emp.idEmpleado = int.Parse(tr1.Text);
            emp.nomEmpleado = tr2.Text;
            emp.sueldo = int.Parse(tr3.Text);
        


            db.Empleado.Add(emp);
            db.SaveChanges();
            MessageBox.Show("Datos correctamente guardados");
        }
    }
}
