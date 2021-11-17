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
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }
        //VARIABLES
        int carga = 0;
        string nombre = "";
        string telefono = "";
        string correo = "";
        string nombreEdit, teleEdit, correoEdit, estadoEdit;

        private void frmClientes_Load(object sender, EventArgs e)
        {
            carga = 0;
            dtgLista.RowHeadersVisible = false;
            dtgEditar.RowHeadersVisible = false;


            renovaredit();
            dtgLista.DataSource = cl.ListaClientes("", "TODOS");
            dtgEditar.DataSource = cl.ListaClientes("", "TODOS");
            lblOK.Visible = false;
            cmbEstadoEdit.Enabled = false;
            cmbEstado.SelectedIndex = 0;
            cmbEditar.SelectedIndex = 0;
            cmbEstadoEdit.SelectedIndex = 0;
            
            carga = 1;


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
                ckEstado.Checked = true;
            }else{
                ckNombre.Checked = false;
                ckTelefono.Checked = false;
                ckEmail.Checked = false;
                ckEstado.Checked = false;
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
            if (ckEstado.Checked == true)
            {
                cmbEstadoEdit.Enabled = true;
            }
            else
            {
                cmbEstadoEdit.Enabled = false;
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
        private void ckEstado_Click(object sender, EventArgs e)
        {
            desbloqueartxt();
        }

        Capa_Datos.Clientes cl = new Clientes();
        public void llenarLista()
        {
            string word = "", estado = "";
                     
            word = txtBuscar.Text;
            estado = cmbEstado.SelectedItem.ToString();
            
            dtgLista.DataSource = cl.ListaClientes(word, estado);


        }
        string cmp = "";
        public void anadircliente()
        {
            
            cl.insertarCliente(this.nombre, this.telefono, this.correo);


        }
        public void limpiaranadir()
        {
            txtNombre.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
        }
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            llenarLista();
        }

        private void cmbBuscarpor_SelectedValueChanged(object sender, EventArgs e)
        {
            if (carga == 1)
            {
                llenarLista();
            }
        }

        private void cmbEstado_SelectedValueChanged(object sender, EventArgs e)
        {
            if (carga == 1)
            {
                llenarLista();
            }
        }
        private void cmbEstadoEdit_SelectedValueChanged(object sender, EventArgs e)
        {
            if (carga == 1)
            {
                llenarLista();
            }
        }
        private void btnGuardarCliente_Click(object sender, EventArgs e)
        {
            nombre = txtNombre.Text;
            correo = txtEmail.Text;

            cmp = cl.verificarCliente(nombre,correo);

            if (cmp != "")
            {
                lblOK.Text = "Al Parecer Existe este Cliente";
                lblOK.ForeColor = Color.Red;
                lblOK.Visible = true;
                
            }else{
                anadircliente();

                lblOK.Text = "Cliente Añadido con Exito";
                lblOK.ForeColor = Color.Green;
                lblOK.Visible = true;

                limpiaranadir();
                llenarLista();
            }
            
           
        }

        private void txtNombre_Click(object sender, EventArgs e)
        {
            lblOK.Visible = false;
        }

        private void txtTelefono_Click(object sender, EventArgs e)
        {
            lblOK.Visible = false;
        }

        private void txtEmail_Click(object sender, EventArgs e)
        {
            lblOK.Visible = false;
        }
        int row = 0;
        int IDCliente = 0;
        string nombrecliente = "";
        string correop = "";
        private void dtgEditar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            row = dtgEditar.CurrentRow.Index;
            nombrecliente = dtgEditar.Rows[row].Cells[0].Value.ToString();

            txtNombreEdit.Text = dtgEditar.Rows[row].Cells[0].Value.ToString();
            txtTelefonoEdit.Text = dtgEditar.Rows[row].Cells[1].Value.ToString();
            correop = dtgEditar.Rows[row].Cells[2].Value.ToString();
            txtEmailEdit.Text = correop;
            cmbEstadoEdit.SelectedItem = dtgEditar.Rows[row].Cells[3].Value.ToString();

            IDCliente = Convert.ToInt32(cl.traerID(nombrecliente,correop));
            
        }
        public void llenareditar()
        {
            string word = "", estado = "";

            word = txtBuscarEdit.Text;
            estado = cmbEditar.SelectedItem.ToString();

            dtgEditar.DataSource = cl.ListaClientes(word, estado);

            
        }

        

        private void txtBuscarEdit_TextChanged(object sender, EventArgs e)
        {
            llenareditar();
        }

        private void cmbEditar_SelectedValueChanged(object sender, EventArgs e)
        {
            if (carga == 1)
            {
                llenareditar();
            }
        }
        
        
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            nombreEdit = txtNombreEdit.Text;
            teleEdit = txtTelefonoEdit.Text;
            correoEdit = txtEmailEdit.Text;
            estadoEdit = cmbEstadoEdit.SelectedItem.ToString();

            cl.ActualizarCliente(IDCliente, nombreEdit, teleEdit, correoEdit,estadoEdit);

            llenareditar();
        }
    }
}
