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
    public partial class FormProducto : Form
    {
        private Producto nuevoProducto;
        public Producto NuevoProducto
        {
            get { return nuevoProducto; }
            //set { nuevoProducto = value; }
        }

        public FormProducto()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (double.TryParse(this.txbPrecio.Text, out double precio) &&
                int.TryParse(this.txbStock.Text, out int stock)){
                    this.nuevoProducto = new Producto(this.txbDescripcion.Text, precio, stock);
            }
            this.DialogResult = DialogResult.OK;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

    }
}
