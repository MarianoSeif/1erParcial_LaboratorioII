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
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            Kwik_E_Mart.listadoProductos.Add(new Producto("Coca", 143.4, 50));
            Kwik_E_Mart.listadoProductos.Add(new Producto("Pelpa", 200, 10));
            DatosPrueba.CargarDatosPrueba();
            this.dtgProductos.DataSource = Kwik_E_Mart.listadoProductos;
            this.dtgCompras.DataSource = Kwik_E_Mart.listadoCompras;
            this.dtgEmpleados.DataSource = Kwik_E_Mart.listadoEmpleados;
            //this.dtgDetalles.DataSource = Kwik_E_Mart.listadoEmpleados;
        }

        private void nuevoProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProducto formProducto = new FormProducto();

            if (formProducto.ShowDialog() == DialogResult.OK)
            {
                string mensaje = "";
                int indice = (Kwik_E_Mart.listadoProductos == formProducto.NuevoProducto);
                if (indice == -1)
                {
                    Kwik_E_Mart.listadoProductos.Add(formProducto.NuevoProducto);
                    mensaje = "Se creó el producto";
                }
                else
                {
                    DialogResult respuesta = MessageBox.Show(
                        "El producto ya existe. Desea agregar la cantidad ingresada al stock y actualizar el precio?",
                        "Actualizar datos del Producto",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );
                    if (respuesta == DialogResult.Yes)
                    {
                        Kwik_E_Mart.listadoProductos[indice].Precio = formProducto.NuevoProducto.Precio;
                        Kwik_E_Mart.listadoProductos[indice].Stock += formProducto.NuevoProducto.Stock;
                        mensaje = "Se actualizaron los datos del producto";
                    }
                }

                this.dtgProductos.DataSource = null;
                this.dtgProductos.DataSource = Kwik_E_Mart.listadoProductos;
                MessageBox.Show(mensaje, "Alta de Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void nuevaCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCompra formCompra = new FormCompra();

            if(formCompra.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Compra finalizada");
            }
        }

        private void hardcodearToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
