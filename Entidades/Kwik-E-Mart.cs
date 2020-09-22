using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    
    public static class Kwik_E_Mart
    {
        public static List<Producto> listadoProductos;
        public static int ultimoIdProducto;

        static Kwik_E_Mart()
        {
            listadoProductos = new List<Producto>();
            ultimoIdProducto = 0;
        }
        
        
    }
}
