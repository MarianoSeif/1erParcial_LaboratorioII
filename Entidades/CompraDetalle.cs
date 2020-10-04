using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class CompraDetalle
    {
        Producto producto;
        int cantidad;
        double precio;

        public double Precio
        {
            get { return precio; }
        }

        public string Producto
        {
            get { return this.producto.Descripcion; }
        }

        public int Cantidad
        {
            get { return this.cantidad; }
        }
        public CompraDetalle(Producto producto, int cantidad, double precio)
        {
            this.producto = producto;
            this.cantidad = cantidad;
            this.precio = precio;
        }

        public static bool operator -(List<Producto> listaProductos, CompraDetalle detalle)
        {
            foreach (Producto producto in listaProductos)
            {
                if(producto == detalle.producto)
                {
                    producto.Stock -= detalle.cantidad;
                    return true;
                }
            }
            return false;
        }
    }
}
