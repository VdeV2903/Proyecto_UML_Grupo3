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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Usuario = Convert.ToString(txtUsuario.Text);
            log.Password = Convert.ToString(txtPassword.Text);

            MessageBox.Show(log.Logear());
        }
    }
}
