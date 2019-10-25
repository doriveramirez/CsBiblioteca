using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class Conexion
    {
        public MySqlConnection conexion {
            get { return ObtenerConexion(); }
        }

        public static MySqlConnection ObtenerConexion()
        {
            MySqlConnection conectar = new MySqlConnection("server=localhost; database=libros; Uid=root; pwd=elrincon1920;");
            conectar.Open();
            return conectar;
        }

    }
}
