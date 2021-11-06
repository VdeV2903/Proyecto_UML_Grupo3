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
    public partial class frmEmpleados : Form
    {
        public frmEmpleados()
        {
            InitializeComponent();
        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            this.dtgLista.RowHeadersVisible = false;
            this.dtgEditar.RowHeadersVisible = false;
            
            cmbFiltro.SelectedIndex = 0;
            cmbEditar.SelectedIndex = 0;

            renovaredit();  
        }
        public void renovarinsercion()
        {
            txtNombre.Clear();
            txtApellidos.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
        }
        public void renovaredit()
        {
            ckNombre.Checked = false;
            ckApellidos.Checked = false;
            ckTelefono.Checked = false;
            ckEmail.Checked = false;

            txtNombreEdit.Enabled = false;
            txtApellidosEdit.Enabled = false;
            txtTelefonoEdit.Enabled = false;
            txtEmailEdit.Enabled = false;

            txtNombreEdit.Clear();
            txtApellidosEdit.Clear();
            txtTelefonoEdit.Clear();
            txtEmailEdit.Clear();
        }
        public void desbloqueartxt()
        {
            if (ckNombre.Checked == true)
            {
                txtNombreEdit.Enabled = true;
            }
            else
            {
                txtNombreEdit.Enabled = false;
                ckTodo.Checked = false;
            }
            if (ckApellidos.Checked == true)
            {
                txtApellidosEdit.Enabled = true;
            }
            else
            {
                txtApellidosEdit.Enabled = false;
                ckTodo.Checked = false;
            }
            if (ckTelefono.Checked == true)
            {
                txtTelefonoEdit.Enabled = true;
            }
            else
            {
                txtTelefonoEdit.Enabled = false;
                ckTodo.Checked = false;
            }
            if (ckEmail.Checked == true)
            {
                txtEmailEdit.Enabled = true;
            }
            else
            {
                txtEmailEdit.Enabled = false;
                ckTodo.Checked = false;
            }

        }
        public void checktodo()
        {
            if (ckTodo.Checked == true)
            {
                ckNombre.Checked = true;
                ckApellidos.Checked = true;
                ckTelefono.Checked = true;
                ckEmail.Checked = true;
            }
            else
            {
                ckNombre.Checked = false;
                ckApellidos.Checked = false;
                ckTelefono.Checked = false;
                ckEmail.Checked = false;
            }
        }
        private void ckTodo_Click(object sender, EventArgs e)
        {
            checktodo();
            desbloqueartxt();
        }
        private void ckNombre_Click(object sender, EventArgs e)
        {
            desbloqueartxt();
        }
        private void ckApellidos_Click(object sender, EventArgs e)
        {
            desbloqueartxt();
        }
        private void ckTelefono_Click(object sender, EventArgs e)
        {
            desbloqueartxt();
        }
        private void ckEmail_Click(object sender, EventArgs e)
        {
            desbloqueartxt();
        }

        
    }
}
