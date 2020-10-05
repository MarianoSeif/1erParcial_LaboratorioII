using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormMain
{
    public partial class FormProductoSumarStock : Form
    {
        public FormProductoSumarStock()
        {
            InitializeComponent();
        }

        private void FormProductoSumarStock_Load(object sender, EventArgs e)
        {
            this.cbxDescripcion.DataSource = Kwik_E_Mart.listadoProductos;
            this.cbxDescripcion.AutoCompleteSource = AutoCompleteSource.ListItems;
            
            //var autocomp = new AutoCompleteStringCollection();

            //foreach (Producto producto in Kwik_E_Mart.listadoProductos)
            //{
            //    autocomp.Add(producto.Descripcion);
            //}
            //this.txbDescripcion.AutoCompleteCustomSource = autocomp;
        }

        private void cbxDescripcion_SelectedValueChanged(object sender, EventArgs e)
        {
            Producto producto = (Producto) this.cbxDescripcion.SelectedItem;
            this.txbId.Text = producto.Id.ToString();
            this.txbPrecio.Text = producto.Precio.ToString();
            this.txbStockActual.Text = producto.Stock.ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(int.TryParse(this.txbStockAgregar.Text, out int cantidad) && cantidad > 0)
            {
                Producto producto = (Producto)this.cbxDescripcion.SelectedItem;
                producto.Stock += cantidad;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Ingrese un numero entero mayor a 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
