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
    public partial class FormMain : Form
    {
        //BindingSource sourceListadoProductos;
        public FormMain()
        {
            InitializeComponent();
            //sourceListadoProductos = new BindingSource();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            Kwik_E_Mart.listadoProductos.Add(new Producto("Coca", 143.4, 50));
            this.dtgProductos.DataSource = Kwik_E_Mart.listadoProductos;
            
            //sourceListadoProductos.DataSource = Kwik_E_Mart.listadoProductos;
            //this.dtgProductos.DataSource = sourceListadoProductos;
            
            //source.ResetBindings(false);
        }

        private void nuevoProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProducto formProducto = new FormProducto();

            if (formProducto.ShowDialog() == DialogResult.OK)
            {
                Kwik_E_Mart.listadoProductos.Add(formProducto.NuevoProducto);
                Kwik_E_Mart.listadoProductos.Add(new Producto("Pelpa", 200, 10));
                //sourceListadoProductos.Add(formProducto.NuevoProducto);
                MessageBox.Show("Se creó el producto", "Alta de Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //sourceListadoProductos.ResetBindings(false);
                this.dtgProductos.DataSource = null;
                this.dtgProductos.DataSource = Kwik_E_Mart.listadoProductos;
            }
        }
    }
}
