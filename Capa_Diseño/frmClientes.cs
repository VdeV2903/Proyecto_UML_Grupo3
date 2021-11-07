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
using Capa_Logica;

namespace Capa_Diseño
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }
        
        private void frmClientes_Load(object sender, EventArgs e)
        {
            
            dtgLista.RowHeadersVisible = false;
            dtgEditar.RowHeadersVisible = false;
            
            cmbEstado.SelectedIndex = 0;
            cmbBuscarpor.SelectedIndex = 0;
            cmbEditar.SelectedIndex = 0;

            renovaredit();
            llenarLista();
        }

        public void renovarinsercion()
        {
            txtNombre.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
        }
        public void renovaredit()
        {
            ckNombre.Checked = false;
            ckTelefono.Checked = false;
            ckEmail.Checked = false;

            txtNombreEdit.Enabled = false;
            txtTelefonoEdit.Enabled = false;
            txtEmailEdit.Enabled = false;

            txtNombreEdit.Clear();
            txtTelefonoEdit.Clear();
            txtEmailEdit.Clear();
        }
        public void checktodo()
        {
            if(ckTodo.Checked == true){
                ckNombre.Checked = true;
                ckTelefono.Checked = true;
                ckEmail.Checked = true;
            }else{
                ckNombre.Checked = false;
                ckTelefono.Checked = false;
                ckEmail.Checked = false;
            }
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
        private void ckTodo_Click(object sender, EventArgs e)
        {
            checktodo();
            desbloqueartxt();
        }
        private void ckNombre_Click(object sender, EventArgs e)
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

        public void llenarLista()
        {
            Clientes cl = new Clientes();
            cl.Word = txtBuscar.Text;
            cl.Estado = cmbEstado.SelectedItem.ToString();
            if(cmbBuscarpor.SelectedItem.ToString() == "Nombre")
            {
                cl.Busquedapor = 1;
            }
            else if(cmbBuscarpor.SelectedItem.ToString() == "Teléfono")
            {
                cl.Busquedapor = 2;
            }
            else if(cmbBuscarpor.SelectedItem.ToString() == "Correo")
            {
                cl.Busquedapor = 3;
            }

            dtgLista.DataSource = cl.ObtenerClientes();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            llenarLista();
        }
    }
}
