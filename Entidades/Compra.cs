using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Compra
    {
        List<CompraDetalle> detalles;
        Persona cliente;
        Persona empleado;
        double total;

        public List<CompraDetalle> Detalles
        {
            get { return this.detalles; }
            set { 
                this.detalles = value;
                CalcularTotal();
            }
        }

        public string Cliente
        {
            get { return this.cliente.Nombre + this.cliente.Apellido; }
        }

        public string Empleado
        {
            get { return this.empleado.Nombre + this.empleado.Apellido; }
        }

        public double Total
        {
            get { return this.total; }
        }

        public Compra()
        {
            detalles = new List<CompraDetalle>();
            total = 0;
        }

        public Compra(Persona cliente, Persona empleado) : this()
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
