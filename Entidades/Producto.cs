using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Producto
    {
        private int id;
        private string descripcion;
        private double precio;
        private int stock;

        public int Id
        {
            get { return this.id; }
        }
        public string Descripcion
        {
            get { return this.descripcion; }
        }

        public double Precio
        {
            get { return this.precio; }
            set { this.precio = value; }
        }

        public int Stock
        {
            get { return this.stock; }
            set { this.stock = value; }
        }

        public Producto(string descripcion, double precio, int stock)
        {
            this.id = Kwik_E_Mart.ultimoIdProducto++;
            this.descripcion = descripcion;
            this.precio = precio;
            this.stock = stock;
        }

        public static int operator ==(List<Producto> listadoProductos, Producto producto)
        {
            for (int i = 0; i < listadoProductos.Count; i++)
            {
                if (Validaciones.CompararStrings(listadoProductos[i].Descripcion, producto.Descripcion))
                {
                    return i;
                }
            }
            return -1;
        }

        public static int operator !=(List<Producto> listadoProductos, Producto producto)
        {
            for (int i = 0; i < listadoProductos.Count; i++)
            {
                if (Validaciones.CompararStrings(listadoProductos[i].Descripcion, producto.Descripcion))
                {
                    return i;
                }
            }
            return -1;
        }

        public override string ToString()
        {
            return this.descripcion;
        }
    }
}
