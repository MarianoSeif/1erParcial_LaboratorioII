using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Persona
    {
        private string nombre;
        private string apellido;
        private int dni;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public int Dni
        {
            get { return dni; }
            set { dni = value; }
        }

        public Persona(string nombre, string apellido, int dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
        }

        public override string ToString()
        {
            return this.nombre + " " +this.apellido;
        }
    }
}
