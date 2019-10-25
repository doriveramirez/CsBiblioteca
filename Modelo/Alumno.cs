using System;
using System.Collections.Generic;

namespace Modelo
{
    public class Alumno
    {
        int id;
        String dni, nombre, apellido1, apellido2;
        private List<string> datos;

        public Alumno(int id, string dni, string nombre, string apellido1, string apellido2)
        {
            this.id = id;
            this.dni = dni;
            this.nombre = nombre;
            this.apellido1 = apellido1;
            this.apellido2 = apellido2;
        }
        public Alumno()
        {
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public String Dni
        {
            get { return dni; }
            set { dni = value; }
        }

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public String Apellido1
        {
            get { return apellido1; }
            set { apellido1 = value; }
        }

        public String Apellido2
        {
            get { return apellido2; }
            set { apellido2 = value; }
        }

    }
}
