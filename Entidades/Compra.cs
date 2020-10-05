using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Compra
    {
        List<CompraDetalle> detalles;
        Cliente cliente;
        Empleado empleado;
        double total;

        public List<CompraDetalle> Detalles
        {
            get { return this.detalles; }
        }

        public Cliente Cliente
        {
            get { return this.cliente; }
            //get { return this.cliente.Nombre + this.cliente.Apellido; }
        }

        public Empleado Empleado
        {
            get { return this.empleado; }
            //get { return this.empleado.Nombre + this.empleado.Apellido; }
        }

        public double Total
        {
            get { return this.total; }
            set { this.total = value; }
        }

        private Compra()
        {
            detalles = new List<CompraDetalle>();
            total = 0;
        }

        public Compra(Cliente cliente, Empleado empleado) : this()
        {
            this.cliente = cliente;
            this.empleado = empleado;
        }
        public void CalcularTotal()
        {
            foreach (CompraDetalle detalle in detalles)
            {
                total += detalle.Precio;
            }
        }
    }
}
