using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Modelo;
using Vista;

namespace Controlador
{
    class Class1
    {
        Conexion conexion = new Modelo.Conexion();

        Conexion cldatos = null;

        Alumno modelo = null;

        DataSet ds = new DataSet();

        Alumno alumnoVo = new Modelo.Alumno();

        Page1 mw = null;

        public Class1(Conexion cldatos)

        {

            this.cldatos = cldatos;

            mw = new Page1();

            //mw.createButtonClick += Mw_clickBoton; // se crea automáticamente al dar doble clic sobre botón

            //mw.Show();
        }
    }
}
