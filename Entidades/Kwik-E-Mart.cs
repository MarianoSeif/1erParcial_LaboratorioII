using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    
    public static class Kwik_E_Mart
    {
        public static List<Producto> listadoProductos;
        public static List<Compra> listadoCompras;
        public static List<Persona> listadoEmpleados;
        public static List<Persona> listadoClientes;
        public static int ultimoIdProducto;

        static Kwik_E_Mart()
        {
            listadoProductos = new List<Producto>();
            listadoCompras = new List<Compra>();
            listadoEmpleados = new List<Persona>();
            listadoClientes = new List<Persona>();
            ultimoIdProducto = 0;
        }
    }
}
