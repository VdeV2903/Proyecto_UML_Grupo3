using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Capa_Datos;

namespace Capa_Diseño
{
    public partial class frmPrincipalVendedor : Form
    {
        Session ss = new Session();
        public frmPrincipalVendedor(string nombre,string carnet)
        {
            InitializeComponent();
            lblNombre.Text = nombre;
            lblCarnet.Text = carnet;
        }
        
        private void AbrirFormulario<T>() where T : Form, new()
        {
            Form formulario = panelcontenedor.Controls.OfType<T>().FirstOrDefault();
            if (formulario != null)
            {
                //Si la instancia esta minimizada la dejamos en su estado normal
                if (formulario.WindowState == FormWindowState.Minimized)
                {
                    formulario.WindowState = FormWindowState.Normal;
                }
                //Si la instancia existe la pongo en primer plano
                formulario.BringToFront();
                return;
            }
            //Se abre el form
            formulario = new T();
            formulario.TopLevel = false;
            panelcontenedor.Controls.Add(formulario);
            panelcontenedor.Tag = formulario;
            formulario.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmClientes>();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmVentas>();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmProductos>();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmCotizaciones>();
        }

        private void frmPrincipalVendedor_Load(object sender, EventArgs e)
        {
            AbrirFormulario<frmInicio>();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmInicio>();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
            this.Close();

        }

        private void frmPrincipalVendedor_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmLogin lg = new frmLogin();
            lg.Show();
        }
    }
}
