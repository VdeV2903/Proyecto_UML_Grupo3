using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Datos;

namespace Capa_Diseño
{
    public partial class frmLogin : Form
    {
        Session ss = new Session();
        private string user = "",pass = "";
        private bool auth = false;
        public string roll = "";
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            lblOK.Visible = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            user = txtUsuario.Text;
            pass = txtPassword.Text;

            auth = ss.authUser(user,pass);
            if (auth == true)
            {
                ss.getSession(user);
                roll = ss.getRoll();
                if(roll == "JEFE/GERENTE")
                {
                    this.Hide();
                    frmPrincipalAdmin pa = new frmPrincipalAdmin(ss.getNombre(), ss.getCarnet());
                    pa.Show();
                }
                else
                {
                    this.Hide();
                    frmPrincipalVendedor pa = new frmPrincipalVendedor(ss.getNombre(),ss.getCarnet());
                    pa.Show();
                }
                
            }
            else
            {
                lblOK.Text = "Credenciales incorrectas";
                lblOK.ForeColor = Color.Red;
                lblOK.Visible = true;
            }
            

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

        private void button1_Click(object sender, EventArgs e)
        {
            frmClientes fr = new frmClientes();
            //frmEmpleados fr = new frmEmpleados();
            //frmProductos fr = new frmProductos();
            //frmVentas fr = new frmVentas();
            fr.Show();
        }
    }
}
