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

        public string Descripcion
        {
            get { return this.descripcion; }
        }

        public double Precio
        {
            get { return this.precio; }
        }

        public int Stock
        {
            get { return this.stock; }
        }

        public Producto(string descripcion, double precio, int stock)
        {
            this.id = Kwik_E_Mart.ultimoIdProducto++;
            this.descripcion = descripcion;
            this.precio = precio;
            this.stock = stock;
        }
    }
}
