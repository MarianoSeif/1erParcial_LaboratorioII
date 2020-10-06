using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Empleado:Persona
    {
        private int id;
        private double sueldo;
        public int Id
        {
            get { return this.id; }
        }

        public double Sueldo
        {
            get { return this.sueldo; }
        }

        /// <summary>
        /// Constructor reutilizando el código de la clase padre
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="sueldo"></param>
        public Empleado(string nombre, string apellido, int dni, double sueldo) : base(nombre, apellido, dni)
        {
            this.id = Kwik_E_Mart.ultimoIdEmpleado++;
            this.sueldo = sueldo;
        }

        /// <summary>
        /// Devuelve el objeto Empleado que coincide con el nombre pasado por parámetro
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns></returns>
        public static Empleado BuscarEmpleadoPorNombre(string nombre)
        {
            foreach (Empleado auxEmpleado in Kwik_E_Mart.listadoEmpleados)
            {
                if (Validaciones.CompararStrings(auxEmpleado.Nombre, nombre))
                {
                    return auxEmpleado;
                }
            }
            return null;
        }

        /// <summary>
        /// Sobreescribe el método heredado reutilizando el código
        /// </summary>
        /// <returns></returns>
        public override string Hola()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Hola());
            sb.AppendLine("Trabajo en el gran Kwik-E-Mart");
            return sb.ToString();
        }
    }
}
