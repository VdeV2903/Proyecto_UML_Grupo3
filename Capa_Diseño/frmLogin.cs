using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Logica;

namespace Capa_Diseño
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Usuario = Convert.ToString(txtUsuario.Text);
            log.Password = Convert.ToString(txtPassword.Text);

            MessageBox.Show(log.Logear());
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuario")
            {
                txtUsuario.Text = "";
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Usuario";
            }
        }
        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Contraseña")
            {
                txtPassword.UseSystemPasswordChar = true;
                txtPassword.Text = "";              
            }
        }
        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.UseSystemPasswordChar = false;
                txtPassword.Text = "Contraseña";            }
        }
        private void pbCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        
    }
}
