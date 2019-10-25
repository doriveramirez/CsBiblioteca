using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Modelo;
using VistaBiblioteca;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace Controller
{
    class Controlador
    {
        
        //Conexion conexion = new Conexion();
        //Alumno alumno = new Alumno();
        //MainWindow vista = new MainWindow();
        //Eventos evento;
        public Controlador()
        {
            MainWindow vista = new MainWindow();
            vista.ShowDialog();
            //this.conexion = new Conexion();
            //Hola();
            //this.evento = new evento(conexion.Conexion);
        }

        //public void Hola()
        //{
        //    //Create a new column to add to the DataGrid
        //    DataGridTextColumn textcol = new DataGridTextColumn();
        //    //Create a Binding object to define the path to the DataGrid.ItemsSource property
        //    //The column inherits its DataContext from the DataGrid, so you don't set the source
        //    Binding b = new Binding("LastName");
        //    //Set the properties on the new column
        //    textcol.Binding = b;
        //    textcol.Header = "Last Name";
        //    DataGrid hola = vista.Library;
        //}
    }
}
