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
        int control = 0;
        Capa_Datos.Empleados em = new Capa_Datos.Empleados();
        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            control = 0;
            this.dtgLista.RowHeadersVisible = false;
            this.dtgEditar.RowHeadersVisible = false;

            dtgLista.DataSource = em.VerEmpleados("", "TODOS");
            dtgEditar.DataSource = em.VerEmpleados("","TODOS");

            cmbFiltro.SelectedIndex = 0;
            cmbEditar.SelectedIndex = 0;
            cmbRoll.SelectedIndex = 1;
            cmbEstadoEditar.SelectedIndex = 0;
            cmbRollEditar.Enabled = false;
            cmbEstadoEditar.Enabled = false;
            lblErrorEditar.Visible = false;
            control = 1;
            txtPass.UseSystemPasswordChar = true;
            txtPass2.UseSystemPasswordChar = true;
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
            if (ckRoll.Checked == true)
            {
                cmbRollEditar.Enabled = true;
            }
            else
            {
                cmbRollEditar.Enabled = false;
                ckTodo.Checked = false;
            }
            if (ckEstadoEdit.Checked == true)
            {
                cmbEstadoEditar.Enabled = true;
            }
            else
            {
                cmbEstadoEditar.Enabled = false;
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
                ckRoll.Checked = true;
                ckEstadoEdit.Checked = true;
            }
            else
            {
                ckNombre.Checked = false;
                ckApellidos.Checked = false;
                ckTelefono.Checked = false;
                ckEmail.Checked = false;
                ckRoll.Checked = false;
                ckEstadoEdit.Checked = false;
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
        private void ckRoll_Click(object sender, EventArgs e)
        {
            desbloqueartxt();
        }
        private void ckEstadoEdit_Click(object sender, EventArgs e)
        {
            desbloqueartxt();
        }
        public bool ValidarEntrada()
        {
            bool ok = true;

            if (String.IsNullOrEmpty(txtNombre.Text))
            {
                ok = false;

            }
            if (String.IsNullOrEmpty(txtApellidos.Text))
            {
                ok = false;

            }
            if (String.IsNullOrEmpty(txtTelefono.Text))
            {
                ok = false;

            }
            if (String.IsNullOrEmpty(txtEmail.Text))
            {
                ok = false;

            }
            if (String.IsNullOrEmpty(txtPass.Text))
            {
                ok = false;

            }
            if (String.IsNullOrEmpty(txtPass2.Text))
            {
                ok = false;

            }

            return ok;
        }
        private string nombres = "", apellidos = "",telefono = "",email = "",usuario="",carnet="";

        private string fil = "";
        public void llenardtgs()
        {
            if (control == 1)
            {
                fil = cmbEditar.SelectedItem.ToString();
                dtgEditar.DataSource = em.VerEmpleados(txtBuscarEditar.Text, fil);
            }
        }
        private void cmbEditar_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenardtgs();
        }

        private void cmbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (control == 1)
            {
                fil = cmbFiltro.SelectedItem.ToString();
                dtgLista.DataSource = em.VerEmpleados(txtBuscar.Text, fil);
            }
        }

        private void txtBuscarEditar_TextChanged(object sender, EventArgs e)
        {
            llenardtgs();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (control == 1)
            {
                fil = cmbFiltro.SelectedItem.ToString();
                dtgLista.DataSource = em.VerEmpleados(txtBuscar.Text, fil);
            }
        }
        private int row = 0;
        string carnete = "";
        string nombrecliente = "";

        private void dtgEditar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblErrorEditar.Visible = false;
            row = dtgEditar.CurrentRow.Index;
            nombrecliente = dtgEditar.Rows[row].Cells[0].Value.ToString();

            txtNombreEdit.Text = dtgEditar.Rows[row].Cells[0].Value.ToString();
            txtApellidosEdit.Text = dtgEditar.Rows[row].Cells[1].Value.ToString();
            carnete = dtgEditar.Rows[row].Cells[2].Value.ToString();
            txtTelefonoEdit.Text = dtgEditar.Rows[row].Cells[3].Value.ToString();
            txtEmailEdit.Text = dtgEditar.Rows[row].Cells[4].Value.ToString();
            cmbRollEditar.SelectedItem = dtgEditar.Rows[row].Cells[5].Value.ToString();
            cmbEstadoEditar.Text = dtgEditar.Rows[row].Cells[6].Value.ToString();


            
            
            
        }
        string nombreempleado = "", apellidosempleado = "", telefonoempleado = "", emailempleado = "", rollem = "", estado = "";

        

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            lblErrorEditar.Visible = false;
            if (carnete != "")
            {
                nombreempleado = txtNombreEdit.Text;
                apellidosempleado = txtApellidosEdit.Text;
                telefonoempleado = txtTelefonoEdit.Text;
                emailempleado = txtEmailEdit.Text;
                rollem = cmbRollEditar.Text;
                estado = cmbEstadoEditar.Text;

                em.actualizarEmpleado(carnete, nombreempleado, apellidosempleado, telefonoempleado, emailempleado, rollem, estado);
                llenardtgs();
                renovaredit();
                carnete = "";
                MessageBox.Show("Empleado Actualizado con Éxito");
            }
            else
            {
                lblErrorEditar.Text = "Seleccione un registro";
                lblErrorEditar.ForeColor = Color.Red;
                lblErrorEditar.Visible = true;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            lblErrorEditar.Visible = false;
            if (carnete != "")
            {
                em.eliminarEmpleado(carnete);
                carnete = "";
                if (control == 1)
                {
                    fil = cmbFiltro.SelectedItem.ToString();
                    dtgLista.DataSource = em.VerEmpleados(txtBuscar.Text, fil);
                }

                llenardtgs();
                renovaredit();
                MessageBox.Show("Empleado Deshablitado con Exito");
            }
            else
            {
                lblErrorEditar.Text = "Seleccione un registro";
                lblErrorEditar.ForeColor = Color.Red;
                lblErrorEditar.Visible = true;
            }

                
        }

        private string pass = "", passc = "",roll="",fecha = "";

        private string sub1 = "",sub2 = "",sub3="";
        public void generarUser()
        {
            this.sub1 = nombres.Substring(0, 3);
            this.sub2 = apellidos.Substring(0, 3);
            this.sub3 = dtmFecha.Value.ToString("MMyyyy");

            txtUser.Text = sub1 + sub2 + sub3;
            txtCarnet.Text = sub1 + sub3 + sub2;
        }
        private string comprobarEmpleado = "";
        public void insertEmpleado()
        {
            lblErrorRegistro.Visible = false;

            comprobarEmpleado = "";
            if (txtPass.Text != txtPass2.Text)
            {
                lblErrorRegistro.Text = "Las contraseñas no coinciden";
                lblErrorRegistro.ForeColor = Color.Red;
                lblErrorRegistro.Visible = true;
                return;
            }
            else
            {
                if (ValidarEntrada())
                {
                    this.nombres = txtNombre.Text;
                    this.apellidos = txtApellidos.Text;
                    this.telefono = txtTelefono.Text;
                    this.email = txtEmail.Text;
                    this.pass = txtPass.Text;
                    this.passc = txtPass2.Text;
                    this.fecha = dtmFecha.Value.ToString("yyyyMMdd");
                    this.roll = Convert.ToString(cmbRoll.SelectedItem);

                    comprobarEmpleado = em.verificarEmpleado(nombres,email,fecha);
                    if (comprobarEmpleado == "")
                    {
                        
                        generarUser();
                        this.usuario = txtUser.Text;
                        this.carnet = txtCarnet.Text;

                        em.insertarEmpleado(this.usuario, this.pass, this.carnet, this.nombres, this.apellidos, this.telefono, this.email, this.roll,this.fecha);
                        renovarinsercion();
                        fil = cmbFiltro.SelectedItem.ToString();
                        dtgLista.DataSource = em.VerEmpleados(txtBuscar.Text, fil);

                        fil = cmbEditar.SelectedItem.ToString();
                        dtgEditar.DataSource = em.VerEmpleados(txtBuscarEditar.Text, fil);
                        MessageBox.Show("Empleado Registrado con Exito");
                    }
                    else
                    {
                        lblErrorRegistro.Text = "Al parecer el empleado ya existe";
                        lblErrorRegistro.ForeColor = Color.Red;
                        lblErrorRegistro.Visible = true;
                    }
                }
                else
                {
                    lblErrorRegistro.Text = "Revise los datos";
                    lblErrorRegistro.ForeColor = Color.Red;
                    lblErrorRegistro.Visible = true;
                }
            }
            
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            ValidarEntrada();
            insertEmpleado();
            
            
        }
    }
}
