using System;

namespace Modelo
{
    public class Alumno
    {
        int id;
        String dni, nombre, apellido1, apellido2;

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

        public Alumno modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

    }
}
