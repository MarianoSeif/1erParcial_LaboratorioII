﻿using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Runtime.InteropServices;
using System.Text;

namespace Entidades
{

    public static class Kwik_E_Mart
    {
        public static List<Producto> listadoProductos;
        public static List<Compra> listadoCompras;
        public static List<Empleado> listadoEmpleados;
        public static List<Cliente> listadoClientes;
        public static Dictionary<string, string> users = new Dictionary<string, string>();
        public static int ultimoIdProducto;
        public static int ultimoIdCliente;
        public static int ultimoIdEmpleado;

        static Kwik_E_Mart()
        {
            listadoProductos = new List<Producto>();
            listadoCompras = new List<Compra>();
            listadoEmpleados = new List<Empleado>();
            listadoClientes = new List<Cliente>();
            ultimoIdProducto = 0;
            ultimoIdCliente = 0;
            ultimoIdEmpleado = 0;
        }

        public static Producto BuscarProductoPorId(int id)
        {
            foreach (Producto item in listadoProductos)
            {
                if (item.Id == id) return item;
            }
            return null;
        }
        public static Producto BuscarProductoPorId(string strId)
        {
            if (int.TryParse(strId, out int id))
            {
                foreach (Producto item in listadoProductos)
                {
                    if (item.Id == id) return item;
                }
            }
            return null;
        }

        public static Cliente BuscarClientePorDni(string strDni)
        {
            int.TryParse(strDni, out int dni);
            foreach (Cliente auxCliente in listadoClientes)
            {
                if (auxCliente.Dni == dni)
                    return auxCliente;
            }
            return null;
        }
    }
}
