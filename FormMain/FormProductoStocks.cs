using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace FormMain
{
    public partial class FormProductoStocks : Form
    {
        private string modo;
        public FormProductoStocks()
        {
            InitializeComponent();
            modo = String.Empty;
        }

        public FormProductoStocks(string modo): this()
        {
            this.modo = modo;
        }

        private void FormProductoStocks_Load(object sender, EventArgs e)
        {
            if(modo == String.Empty)
            {
                this.dtgProductos.DataSource = Kwik_E_Mart.listadoProductos;
            }
            else if (modo == "menos de 10")
            {
                List<Producto> listaMenosDe10 = new List<Producto>();
                foreach (Producto producto in Kwik_E_Mart.listadoProductos)
                {
                    if (producto.Stock < 10)
                    {
                        listaMenosDe10.Add(producto);
                    }
                }
                this.dtgProductos.DataSource = null;
                this.dtgProductos.DataSource = listaMenosDe10;
            }
            
        }
    }
}
