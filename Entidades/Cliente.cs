using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Cliente: Persona
    {
        private int id;

        public int Id
        {
            get { return this.id; }
        }
        public Cliente(string nombre, string apellido, int dni):base(nombre, apellido, dni)
        {
            this.id = Kwik_E_Mart.ultimoIdCliente++;
        }
    }
}
