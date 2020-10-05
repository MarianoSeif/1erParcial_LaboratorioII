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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        private void FormLogin_Load(object sender, EventArgs e)
        {
            DatosPrueba.CargarUsuarios();
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if(Kwik_E_Mart.users.TryGetValue(this.txbUser.Text, out string pass))
            {
                if(pass == this.txbPass.Text)
                {
                    this.Hide();
                    FormMain formMain = new FormMain();
                    formMain.Show();
                }
                else
                {
                    MessageBox.Show("La contraseña es incorrecta", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("El usuario no existe", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        
    }
}
