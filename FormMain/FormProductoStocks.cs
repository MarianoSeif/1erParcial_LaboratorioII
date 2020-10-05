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
            else if (modo == "existencia")
            {
                List<Producto> listaExistencia = new List<Producto>();
                foreach (Producto producto in Kwik_E_Mart.listadoProductos)
                {
                    if (producto.Stock > 0)
                    {
                        listaExistencia.Add(producto);
                    }
                }
                this.dtgProductos.DataSource = null;
                this.dtgProductos.DataSource = listaExistencia;
            }
            this.dtgProductos.Columns[0].Width = 100;
            this.dtgProductos.Columns[1].Width = 310;
            this.dtgProductos.Columns[2].Width = 150;
            this.dtgProductos.Columns[3].Width = 150;

        }
    }
}
