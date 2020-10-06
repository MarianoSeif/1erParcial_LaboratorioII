using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormMain
{
    public partial class FormCompra : Form
    {
        List<Producto> listaProductosVenta;
        private Compra nuevaCompra;
        public Compra NuevaCompra
        {
            get { return this.nuevaCompra; }
        }

        public FormCompra()
        {
            InitializeComponent();
        }

        private void FormCompra_Load(object sender, EventArgs e)
        {
            //Armo los autocomplete para los campos de datos del cliente
            var nombres = new AutoCompleteStringCollection();
            var apellidos = new AutoCompleteStringCollection();
            var dnis = new AutoCompleteStringCollection();

            foreach (Cliente cliente in Kwik_E_Mart.listadoClientes)
            {
                nombres.Add(cliente.Nombre);
                apellidos.Add(cliente.Apellido);
                dnis.Add(cliente.Dni.ToString());
            }

            //Cargo los productos disponibles para la venta
            listaProductosVenta = new List<Producto>();
            foreach (Producto producto in Kwik_E_Mart.listadoProductos)
            {
                if(producto.Stock > 0)
                {
                    listaProductosVenta.Add(producto);
                }
            }
            //Seteo las fuentes de datos de los componentes
            this.txbNombre.AutoCompleteCustomSource = nombres;
            this.txbApellido.AutoCompleteCustomSource = apellidos;
            this.txbDni.AutoCompleteCustomSource = dnis;
            this.cmbEmpleado.DataSource = Kwik_E_Mart.listadoEmpleados;
            this.dtgProductos.DataSource = listaProductosVenta;
            //DataGrid Productos
            this.dtgProductos.Columns[0].Width = 100;
            this.dtgProductos.Columns[1].Width = 310;
            this.dtgProductos.Columns[2].Width = 150;
            this.dtgProductos.Columns[3].Width = 150;
            //DataGrid Productos Vendidos
            this.dtgProductosVendidos.Columns.Add("cantidad", "Cantidad");
            this.dtgProductosVendidos.Columns.Add("id", "Id");
            this.dtgProductosVendidos.Columns.Add("descripcion", "Descripcion");
            this.dtgProductosVendidos.Columns.Add("precio", "Precio");
            this.dtgProductosVendidos.Columns[0].Width = 125;
            this.dtgProductosVendidos.Columns[1].Width = 125;
            this.dtgProductosVendidos.Columns[2].Width = 310;
            this.dtgProductosVendidos.Columns[3].Width = 150;
            for (int i = 1; i < 4; i++)
            {
                this.dtgProductosVendidos.Columns[i].ReadOnly = true;
            }
        }

        /// <summary>
        /// Busca el dni del cliente ingresado a partir de su nombre y apellido
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <returns></returns>
        private int BuscarDni(string nombre, string apellido)
        {
            foreach (Persona cliente in Kwik_E_Mart.listadoClientes)
            {
                if(Validaciones.CompararStrings(cliente.Nombre, nombre) 
                    && Validaciones.CompararStrings(cliente.Apellido, apellido))
                {
                    return cliente.Dni;
                }
            }
            return -1;
        }
        
        /// <summary>
        /// Cuando ingreso el apellido busca el dni y lo carga en el textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txbApellido_TextChanged(object sender, EventArgs e)
        {
            if (this.txbDni.Text == String.Empty)
            {
                int dni = BuscarDni(this.txbNombre.Text, this.txbApellido.Text);
                if (dni != -1)
                {
                    this.txbDni.Text = dni.ToString();
                }
            }

            if (this.txbApellido.Text == "Simpson")
            {
                this.lblMensajeTotal.Text = "Descuento del 13% por ser miembro de la familia Simpson";
            }
        }

        #region Drag and Drop
        private void dtgProductos_MouseDown(object sender, MouseEventArgs e)
        {
            this.dtgProductos.ClearSelection();
            int indiceFila = this.dtgProductos.HitTest(e.X, e.Y).RowIndex;
            if(indiceFila > -1 && indiceFila < this.dtgProductos.Rows.Count)
            {
                dtgProductos.Rows[indiceFila].Selected = true;
                this.dtgProductos.DoDragDrop(this.dtgProductos.SelectedRows[0], DragDropEffects.Copy);
            }            
        }

        private void dtgProductosVendidos_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void dtgProductosVendidos_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(DataGridViewRow)))
            {
                if (e.Effect == DragDropEffects.Copy)
                {
                    bool estaEnElListado = false;
                    DataGridViewRow filaParaAgregar = (DataGridViewRow)e.Data.GetData(typeof(DataGridViewRow));
                    Producto auxProducto = (Producto) filaParaAgregar.DataBoundItem;
                    if (this.dtgProductosVendidos.Rows.Count == 0)
                    {
                        this.dtgProductosVendidos.Rows.Add("", auxProducto.Id, auxProducto.Descripcion, auxProducto.Precio);
                    }
                    else
                    {
                        foreach (DataGridViewRow fila in this.dtgProductosVendidos.Rows)
                        {
                            //verifica si el producto ya está en el listado antes de agregarlo
                            if (fila.Cells[1].Value.ToString() == auxProducto.Id.ToString())
                            {
                                MessageBox.Show("Este producto ya se encuentra en el listado", "Error de producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                estaEnElListado = true;
                            }
                        }
                        if (!estaEnElListado)
                        {
                            this.dtgProductosVendidos.Rows.Add("", auxProducto.Id, auxProducto.Descripcion, auxProducto.Precio);
                        }
                    }
                }
            }
        }
        #endregion

        
        /// <summary>
        /// Eventlistener para cuando cambia la columna cantidad del datagrid de productos vendidos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtgProductosVendidos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            string strCantidad = String.Empty;
            //obtengo el id del producto
            string idProducto = this.dtgProductosVendidos.Rows[e.RowIndex].Cells[1].Value.ToString();
            //obtengo la cantidad del producto
            if (this.dtgProductosVendidos.Rows[e.RowIndex].Cells[0].Value != null){
                strCantidad = this.dtgProductosVendidos.Rows[e.RowIndex].Cells[0].Value.ToString();
            }

            Producto producto = Kwik_E_Mart.BuscarProductoPorId(idProducto);
            if (int.TryParse(strCantidad, out int cantidad) && cantidad >0)
            {
                if (cantidad <= producto.Stock)
                {
                    CalcularTotal();
                }
                else
                {
                    MessageBox.Show(
                        $"Solo hay {producto.Stock} unidades de {producto.Descripcion}",
                        "Error en columna cantidad",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    this.dtgProductosVendidos.Rows[e.RowIndex].Cells[0].Value = producto.Stock;
                }
            }
            else
            {
                MessageBox.Show(
                        "La cantidad debe ser un numero entero mayor a 0",
                        "Error en columna cantidad",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
            }            
        }

        /// <summary>
        /// Calcula el total de la compra
        /// </summary>
        /// <returns></returns>
        private bool CalcularTotal()
        {
            double total = 0;
            foreach (DataGridViewRow fila in this.dtgProductosVendidos.Rows)
            {
                int.TryParse(fila.Cells[0].Value.ToString(), out int cantidad);
                double.TryParse(fila.Cells[3].Value.ToString(), out double precio);
                if (fila.Cells[0].Value.ToString() == String.Empty)
                {
                    MessageBox.Show("Ingrese un numero entero en la columna cantidad", "Ingrese una cantidad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    total += cantidad * precio;
                }
            }
            if (this.txbApellido.Text == "Simpson")
            {
                total -= total * 13 / 100;
            }
            this.lblTotalNumero.Text = total.ToString();
            return true;
        }


        private void btnFinalizarCompra_Click(object sender, EventArgs e)
        {
            if (ComprobarDatosCliente() && CalcularTotal())
            {
                if (this.dtgProductosVendidos.Rows.Count <= 0)
                {
                    MessageBox.Show("Agregue al menos un Producto arrastrando y soltando desde la tabla de Productos y agregue una cantidad", "Agregue un producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Empleado empleado = (Empleado) this.cmbEmpleado.SelectedItem;
                    Cliente cliente = BuscarCliente(this.txbNombre.Text, this.txbApellido.Text, this.txbDni.Text);

                    if (cliente == null)
                    {
                        int dni = Validaciones.StringDni(this.txbDni.Text);
                        cliente = new Cliente(this.txbNombre.Text, this.txbApellido.Text, dni);
                        Kwik_E_Mart.listadoClientes.Add(cliente);
                    }
                    this.nuevaCompra = new Compra(cliente, empleado);
                    foreach (DataGridViewRow fila in this.dtgProductosVendidos.Rows)
                    {
                        int.TryParse(fila.Cells[0].Value.ToString(), out int cantidad);
                        string idProducto = fila.Cells[1].Value.ToString();
                        double.TryParse(fila.Cells[3].Value.ToString(), out double precio);
                        Producto producto = Kwik_E_Mart.BuscarProductoPorId(idProducto);
                        nuevaCompra.Detalles.Add(new CompraDetalle(producto, cantidad, precio));
                        if(double.TryParse(this.lblTotalNumero.Text, out double total))
                        {
                            nuevaCompra.Total = total;
                        }                        
                    }
                    this.DialogResult = DialogResult.OK;
                }
            }
        }

        /// <summary>
        /// Comprueba los datos ingresados del cliente
        /// </summary>
        /// <returns></returns>
        private bool ComprobarDatosCliente()
        {
            if (Validaciones.StringNoVacio(this.txbNombre.Text) && 
                Validaciones.StringNoVacio(this.txbApellido.Text) && 
                Validaciones.StringDni(this.txbDni.Text) != -1)
            {
                return true;                
            }
            else
            {
                MessageBox.Show(
                    "Complete correctamente todos los datos del cliente",
                    "Ingrese Cliente",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return false;
            }
        }

        /// <summary>
        /// Devuelve el objeto de tipo Cliente que coincide con los datos pasados por parámetros
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <returns></returns>
        private Cliente BuscarCliente(string nombre, string apellido, string dni)
        {
            Cliente auxCliente = Kwik_E_Mart.BuscarClientePorDni(dni);
            if (auxCliente != null)
            {
                if( !Validaciones.CompararStrings(auxCliente.Nombre, nombre) ||
                    !Validaciones.CompararStrings(auxCliente.Apellido, apellido))
                {
                    MessageBox.Show("Ya existe un cliente con ese DNI!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
            return auxCliente;
        }

        private void btnAnularCompra_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Está seguro que desea anular la compra?", "Anular Compra", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (respuesta == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }

        private void btnCalcularTotal_Click(object sender, EventArgs e)
        {
            CalcularTotal();
        }
    }
}
