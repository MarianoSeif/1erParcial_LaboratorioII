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
        }

        public Empleado Empleado
        {
            get { return this.empleado; }
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

        /// <summary>
        /// Constructor reutilizando el constructor por defecto
        /// </summary>
        /// <param name="cliente"></param>
        /// <param name="empleado"></param>
        public Compra(Cliente cliente, Empleado empleado) : this()
        {
            this.cliente = cliente;
            this.empleado = empleado;
        }
        
        /// <summary>
        /// Calcula el total de la compra
        /// </summary>
        public void CalcularTotal()
        {
            foreach (CompraDetalle detalle in detalles)
            {
                total += detalle.Precio;
            }
        }
    }
}
