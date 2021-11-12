using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Diseño
{
    public partial class frmPrincipalAdmin : Form
    {
        public frmPrincipalAdmin()
        {
            InitializeComponent();
        }
        /*
        private void AbrirFormInPanel(object formHijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }
        */
        private void frmPrincipalAdmin_Load(object sender, EventArgs e)
        {

        }
        private void AbrirFormulario<T>() where T : Form, new()
        {
            Form formulario = panelContenedor.Controls.OfType<T>().FirstOrDefault();
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
            panelContenedor.Controls.Add(formulario);
            panelContenedor.Tag = formulario;
            formulario.Show();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmClientes>();
        }
        private void btnVentas_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmVentas>();
        }
        private void btnProductos_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmProductos>();
        }
        private void btnCotizaciones_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmCotizaciones>();
        }
        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmEmpleados>();
        }

        private void btnDocumentos_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmDocumentosFiscales>();
        }
        private void btnReportes_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmReportes>();
        }
        
    }
}
