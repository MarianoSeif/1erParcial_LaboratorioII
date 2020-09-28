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
        public Empleado(string nombre, string apellido, int dni, double sueldo) : base(nombre, apellido, dni)
        {
            this.id = Kwik_E_Mart.ultimoIdEmpleado++;
            this.sueldo = sueldo;
        }

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
    }
}
