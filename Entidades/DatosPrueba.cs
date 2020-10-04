using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public static class DatosPrueba
    {
        public static void CargarDatosPrueba()
        {
            //Generar Clientes
            string[] nombresClientes = {"Homero", "Marge", "Ned", "Montgomery", "Seymour"};
            string[] apellidosClientes = { "Simpson", "Simpson", "Flanders", "Burns", "Skinner" };
            int[] dnisClientes = { 15321654, 16987654, 15666666, 1357159, 16644799 };
            for (int i = 0; i < 5; i++)
            {
                Kwik_E_Mart.listadoClientes.Add(new Cliente(nombresClientes[i], apellidosClientes[i], dnisClientes[i]));
            }

            //Generar Empleados
            Kwik_E_Mart.listadoEmpleados.Add(new Empleado("Apu", "Nahasapeemapetilon", 159764115, 60000));
            Kwik_E_Mart.listadoEmpleados.Add(new Empleado("Sanjay", "Nahasapeemapetilon", 13441023, 50000));

            //Generar Productos
            string[] descripcionProducto = {"Pan","Harina","Fideos","Arroz","Atun","Arvejas","Leche","Queso",
                "Yogur", "Manteca", "Papas fritas", "Escarbadientes", "Galletitas", "Vino", "Cerveza", "Vodka",
                "Gin", "Campari", "Fenet", "Gancia", "Cinzano", "Desodorante", "Jabon", "Shampoo", "Lavandina",
                "Perfume", "Alfajor", "Chocolate", "Chicles", "Encendedor"
            };
            double[] preciosProductos = { 60,50,45,48,115,42,55,120,80,140,60,34,51,200,138,250,235,270,310,210,
                205,105,48,180,70,350,62,123,49,33
            };
            int[] stockProductos = { 15,40,45,38,61,8,25,35,28,26,60,132,155,47,174,5,29,44,87,96,77,133,210,7,49,
                21,70,2,38,52
            };

            for (int i = 0; i < 30; i++)
            {
                Kwik_E_Mart.listadoProductos.Add(new Producto(descripcionProducto[i], preciosProductos[i], stockProductos[i]));
            }

            //Generar Compras
            Random rd = new Random();
            for (int i = 0; i < 50; i++)
            {
                int indiceEmpleado = rd.Next(0, Kwik_E_Mart.listadoEmpleados.Count);
                int indiceCliente = rd.Next(0, Kwik_E_Mart.listadoClientes.Count);
                
                Kwik_E_Mart.listadoCompras.Add(new Compra(
                    Kwik_E_Mart.listadoClientes[indiceCliente],
                    Kwik_E_Mart.listadoEmpleados[indiceEmpleado]
                ));

                for (int j = 0; j < rd.Next(2,5); j++)
                {
                    int indiceProducto = rd.Next(0, Kwik_E_Mart.listadoProductos.Count);
                    CompraDetalle compraDetalle = new CompraDetalle(
                        Kwik_E_Mart.listadoProductos[indiceProducto],
                        rd.Next(1,5),
                        Kwik_E_Mart.listadoProductos[indiceProducto].Precio
                    );
                    Kwik_E_Mart.listadoCompras[i].Detalles.Add(compraDetalle);
                    Kwik_E_Mart.listadoCompras[i].CalcularTotal();
                }
            }
        }
    }
}
