using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Modelo;
using VistaBiblioteca;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using MySql.Data.MySqlClient;
using System.Collections.ObjectModel;

namespace Controller
{
    class Controlador
    {

        MainWindow vista = new MainWindow();
        Eventos modelo = new Eventos();
        Alumno alumno;
        Conexion conexion = new Conexion();
        ObservableCollection<Alumno> alumnos = new ObservableCollection<Alumno>();

        void DeleteClick(Object sender,
                           EventArgs e)
        {
            int value;
            if (vista.id.Text == "")
            {
                MessageBox.Show("Debe introducir un id");
            } else if (!int.TryParse(vista.id.Text, out value))
            {
                MessageBox.Show("Debe introducir un número entero");
            } else
            {
                modelo.Delete(System.Convert.ToInt32(vista.id.Text), conexion);
            }
        }

        public Controlador()
        {
            vista.Delete.Click += new RoutedEventHandler(this.DeleteClick);
            iniciarTabla();
            Console.WriteLine("antes de showdialog");
            vista.ShowDialog();
        }

        private void iniciarTabla()
        {
            string query = "Select * from alumnos";
            MySqlCommand getAlumnos = new MySqlCommand(query, conexion.conexion);
            MySqlDataReader readAlumnos = getAlumnos.ExecuteReader();
            readAlumnos.Read();
            int id;
            String dni, nombre, apellido1, apellido2;
            while (readAlumnos.Read())
            {
                id = System.Convert.ToInt32(readAlumnos["registro"].ToString());
                dni = readAlumnos["dni"].ToString();
                nombre = readAlumnos["nombre"].ToString();
                apellido1 = readAlumnos["apellido1"].ToString();
                apellido2 = readAlumnos["apellido2"].ToString();
                alumno = new Alumno(id, dni, nombre, apellido1, apellido2);
                alumnos.Add(alumno);
            }
            vista.setAlumnos(alumnos);
        }

    }
}
