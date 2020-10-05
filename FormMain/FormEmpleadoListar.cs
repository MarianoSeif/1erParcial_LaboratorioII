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
    public partial class FormEmpleadoListar : Form
    {
        public FormEmpleadoListar()
        {
            InitializeComponent();
        }

        private void FormEmpleadoListar_Load(object sender, EventArgs e)
        {
            this.dtgEmpleados.DataSource = Kwik_E_Mart.listadoEmpleados;
            this.dtgEmpleados.Columns[0].Width = 40;
            this.dtgEmpleados.Columns[1].Width = 80;
            this.dtgEmpleados.Columns[2].Width = 225;
            this.dtgEmpleados.Columns[3].Width = 250;
            this.dtgEmpleados.Columns[4].Width = 131;
        }
    }
}
