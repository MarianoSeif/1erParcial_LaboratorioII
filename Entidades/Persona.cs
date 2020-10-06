using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public abstract class Persona
    {
        protected string nombre;
        protected string apellido;
        protected int dni;
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

        /// <summary>
        /// Devuelve un string con el saludo de la persona
        /// </summary>
        /// <returns></returns>
        public virtual string Hola()
        {
            return $"Hola!, mi nombre es {nombre} {apellido}";
        }

        /// <summary>
        /// Sobreescribo el metodo ToString heredado de Object
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.nombre + " " +this.apellido;
        }
    }
}
