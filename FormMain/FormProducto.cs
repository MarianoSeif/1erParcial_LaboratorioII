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
        }

        public FormProducto()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            LimpiarErrores();
            string strPrecio = this.txbPrecio.Text.Replace('.', ',');

            if (this.txbDescripcion.Text == String.Empty || this.txbDescripcion.Text.Length < 3)
            {
                this.lblErrorDescripcion.Text = "Ingrese una descripcion(minimo 3 caracteres)";
            }
            //else if (buscarProductoEnListado(this.txbDescripcion.Text))
            //{
            //    this.lblErrorDescripcion.Text = "Ya existe un producto con esa descripción";
            //}
            else if (!double.TryParse(strPrecio, out double precio))
            {
                this.lblErrorPrecio.Text = "Ingrese un numero";
            }
            else if (!int.TryParse(this.txbStock.Text, out int stock))
            {
                this.lblErrorStock.Text = "Ingrese un numero entero";
            }
            else 
            { 
                this.nuevoProducto = new Producto(this.txbDescripcion.Text, precio, stock);
                this.DialogResult = DialogResult.OK;
            }
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void LimpiarErrores()
        {
            this.lblErrorDescripcion.Text = String.Empty;
            this.lblErrorPrecio.Text = String.Empty;
            this.lblErrorStock.Text = String.Empty;
        }
    }
}
