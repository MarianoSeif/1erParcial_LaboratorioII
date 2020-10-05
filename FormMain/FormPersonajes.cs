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
    public partial class FormPersonajes : Form
    {
        List<Persona> personajes;
        public FormPersonajes()
        {
            InitializeComponent();
        }

        private void FormPersonajes_Load(object sender, EventArgs e)
        {
            personajes = new List<Persona>();
            foreach (Cliente cliente in Kwik_E_Mart.listadoClientes)
            {
                personajes.Add(cliente);
            }
            foreach (Empleado empleado in Kwik_E_Mart.listadoEmpleados)
            {
                personajes.Add(empleado);
            }

            lsvPersonajes.View = View.Details;
            lsvPersonajes.Columns.Add("Personaje", 700);

            this.lsvPersonajes.Items.Add("Marge", 0);
            this.lsvPersonajes.Items.Add("Homero", 1);
            this.lsvPersonajes.Items.Add("Burns", 2);
            this.lsvPersonajes.Items.Add("Flanders", 3);
            this.lsvPersonajes.Items.Add("Skinner", 4);
            this.lsvPersonajes.Items.Add("Sanjay", 5);
            this.lsvPersonajes.Items.Add("Apu", 6);
        }

        private void lsvPersonajes_MouseClick(object sender, MouseEventArgs e)
        {
            string nombre = this.lsvPersonajes.SelectedItems[0].Text;
            foreach (Persona personaje in personajes)
            {
                if (personaje.Nombre == nombre || personaje.Apellido == nombre)
                {
                    MessageBox.Show(personaje.Hola(), "Ejemplo de Polimorfismo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    break;
                }
            }
        }
    }
}
