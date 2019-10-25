using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Modelo
{
    public class Eventos
    {
        protected MySqlConnection conexion;

        public Eventos()
        {
        }

        private ObservableCollection<Alumno> alumnos;
        public ObservableCollection<Alumno> Alumnos
        {
            get { return alumnos; }
            set { alumnos = value; }
        }
        public Eventos(MySqlConnection conexion)
        {
            this.conexion = conexion;
            Console.WriteLine("se ha conectado");
        }

        public void Delete(int id, Conexion conexionAux)
        {
            Console.WriteLine(id);
            string query = "delete from alumnos where registro = " + id;
            MySqlCommand deleteAlumnos = new MySqlCommand(query, conexionAux.conexion);
            deleteAlumnos.ExecuteReader();
        }

    }
}
