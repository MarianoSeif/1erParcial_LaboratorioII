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
    public partial class FormCompraInforme : Form
    {
        public FormCompraInforme()
        {
            InitializeComponent();
        }

        private void FormCompraInforme_Load(object sender, EventArgs e)
        {
            List<Empleado> list = new List<Empleado>();
            list.Add(new Empleado(String.Empty, String.Empty, 1111111, 0));
            foreach (Empleado empleado in Kwik_E_Mart.listadoEmpleados)
            {
                list.Add(empleado);
            }
            this.cmbEmpleado.DataSource = list;
            cargarDataGrid(-1);
        }

        private void cmbEmpleado_SelectedValueChanged(object sender, EventArgs e)
        {
            Empleado empleado = (Empleado)this.cmbEmpleado.SelectedItem;
            if(empleado.Nombre == String.Empty)
            {
                cargarDataGrid(-1);
            }
            else
            {
                cargarDataGrid(empleado.Id);
            }
        }

        private bool cargarDataGrid(int idEmpleado)
        {
            bool retorno = false;
            if(idEmpleado == -1)
            {
                this.dtgCompras.DataSource = null;
                this.dtgCompras.DataSource = Kwik_E_Mart.listadoCompras;
                retorno = true;
            }
            else
            {
                List<Compra> listaCompras = new List<Compra>();
                foreach (Compra compra in Kwik_E_Mart.listadoCompras)
                {
                    if(compra.Empleado.Id == idEmpleado)
                    {
                        listaCompras.Add(compra);
                    }
                }
                this.dtgCompras.DataSource = null;
                this.dtgCompras.DataSource = listaCompras;
                retorno = true;
            }
            this.dtgCompras.Columns[0].Width = 300;
            this.dtgCompras.Columns[1].Width = 300;
            this.dtgCompras.Columns[2].Width = 171;
            return retorno;
        }
    }
}
