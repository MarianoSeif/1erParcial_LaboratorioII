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

        public static Cliente BuscarClientePorDni(string strDni)
        {
            int.TryParse(strDni, out int dni);
            foreach (Cliente auxCliente in Kwik_E_Mart.listadoClientes)
            {
                if (auxCliente.Dni == dni)
                    return auxCliente;
            }
            return null;
        }

        //public bool operator ==(List<Cliente> listadoClientes, string strDni)
        //{
        //    foreach (Cliente auxCliente in Kwik_E_Mart.listadoClientes)
        //    {
        //        int.TryParse(strDni, out int dni);
        //        if (auxCliente.Dni == dni)
        //        {
        //            return 
        //        }
        //    }
        //}
    }
}
