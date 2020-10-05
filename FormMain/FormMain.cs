using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using System.Media;

namespace FormMain
{
    public partial class FormMain : Form
    {
        private bool menuIsActive = false;
        static System.Windows.Forms.Timer showTimer;
        static System.Windows.Forms.Timer hideTimer;
        public FormMain()
        {
            InitializeComponent();
        }
        
        private void FormMain_Load(object sender, EventArgs e)
        {
            DatosPrueba.CargarDatosPrueba();
            this.menuStrip1.Visible = false;

            showTimer = new System.Windows.Forms.Timer();
            hideTimer = new System.Windows.Forms.Timer();

            showTimer.Tick += new EventHandler(showTimer_Tick);
            showTimer.Interval = 100;
            showTimer.Start();

            hideTimer.Tick += new EventHandler(hideTimer_Tick);
            hideTimer.Interval = 125;
            hideTimer.Start();
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
                MessageBox.Show(mensaje, "Alta de Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void nuevaCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCompra formCompra = new FormCompra();

            if(formCompra.ShowDialog() == DialogResult.OK)
            {
                //resto los productos vendidos del stock
                foreach (CompraDetalle detalle in formCompra.NuevaCompra.Detalles)
                {
                    if(!(Kwik_E_Mart.listadoProductos - detalle))
                    {
                        MessageBox.Show(
                            "Algo salió mal al intentar procesar la compra",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                    }
                }
                Kwik_E_Mart.listadoCompras.Add(formCompra.NuevaCompra);
                SoundPlayer sonido = new SoundPlayer(@"C:\Users\ms\source\repos\2do_Parcial_Labo_Seif.Mariano_2D_2doCuatri_2020\media\sonidos\classiccoin.wav");
                sonido.Play();
                Task mensaje = this.graciasVuelvanProntos();
            }
        }

        private void verStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProductoStocks formProductoStocks = new FormProductoStocks("existencia");
            formProductoStocks.ShowDialog();
        }

        private void stock10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProductoStocks formProductoStocks = new FormProductoStocks("menos de 10");
            formProductoStocks.ShowDialog();
        }
        private void todosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProductoStocks formProductoStocks = new FormProductoStocks();
            formProductoStocks.ShowDialog();
        }

        private void verComprasXEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCompraInforme formCompraInforme = new FormCompraInforme();
            formCompraInforme.ShowDialog();
        }

        private void listarEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEmpleadoListar formEmpleadoListar = new FormEmpleadoListar();
            formEmpleadoListar.ShowDialog();
        }
        private async Task graciasVuelvanProntos()
        {
            this.lblGracias.Text = "Gracias!! Vuelva prontosss";
            await Task.Delay(5000);
            this.lblGracias.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if( MessageBox.Show(
                    "Está seguro que desea salir del minisuper?",
                    "Salir",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void sumarStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProductoSumarStock formProductoSumarStock = new FormProductoSumarStock();
            formProductoSumarStock.ShowDialog();
        }

        #region ocultar menu
        private void hideTimer_Tick(object sender, EventArgs e)
        {
            var p = this.menuStrip1.PointToClient(MousePosition);
            if (menuIsActive)
                return;
            if (menuStrip1.ClientRectangle.Contains(p))
                return;
            foreach (ToolStripMenuItem item in menuStrip1.Items)
                if (item.DropDown.Visible)
                    return;
            this.menuStrip1.Visible = false;
        }

        private void showTimer_Tick(object sender, EventArgs e)
        {
            var p = this.PointToClient(MousePosition);
            if (this.ClientRectangle.Contains(p) && p.Y < 20)
                this.menuStrip1.Visible = true;
        }
        private void menuStrip1_MenuActivate(object sender, EventArgs e)
        {
            menuIsActive = true;
        }
        private void menuStrip1_MenuDeactivate(object sender, EventArgs e)
        {
            menuIsActive = false;
            this.BeginInvoke(new Action(() => { this.menuStrip1.Visible = false; }));
        }

        #endregion

        private void personajesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPersonajes formPersonajes = new FormPersonajes();
            formPersonajes.ShowDialog();
        }
    }
}
