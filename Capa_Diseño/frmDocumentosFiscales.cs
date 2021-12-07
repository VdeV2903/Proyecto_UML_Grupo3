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
    public partial class frmDocumentosFiscales : Form
    {
        Ventas vt = new Ventas();
        public frmDocumentosFiscales()
        {
            InitializeComponent();
        }

        private void frmDocumentosFiscales_Load(object sender, EventArgs e)
        {
            cargarVentas();
            cmbTipo.SelectedIndex = 0;
        }

        private void cargarVentas()
        {
            dtgVentas.DataSource = vt.verVentas(txtBuscarN.Text);
            dtgVentas.Columns[5].Visible = false;
        }

        private void txtNombreProd_TextChanged(object sender, EventArgs e)
        {
            cargarVentas();
        }
        private string ok;

        private bool comprobar()
        {
            bool comp = true;
            if (String.IsNullOrEmpty(txtCliente.Text))
            {
                comp = false;
            }
            if (String.IsNullOrEmpty(txtNit.Text))
            {
                comp = false;
            }
            if (String.IsNullOrEmpty(txtDireccion.Text))
            {
                comp = false;
            }
            if (lblCodigo.Text == "---")
            {
                comp = false;
            }

            return comp;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            frmDocumentoReporte drp = new frmDocumentoReporte();

            if (comprobar())
            {
                ok = Convert.ToString(dtgDatos.Rows[0].Cells[0].Value);
                if (ok == "")
                {
                    MessageBox.Show("No hay Datos de contenido");
                }
                else
                {
                    for (int i = 0; i < dtgDatos.Rows.Count - 1; i++)
                    {
                        DatosDoc ddc = new DatosDoc();
                        ddc.titulo = cmbTipo.SelectedItem.ToString();
                        ddc.nit = txtNit.Text.ToString();
                        ddc.cliente = Convert.ToString(txtCliente.Text);
                        ddc.direccion = Convert.ToString(txtDireccion.Text);
                        ddc.nota = Convert.ToString(txtNota.Text);
                        ddc.codigo = Convert.ToString(lblCodigo.Text);
                        ddc.detalle = (string)this.dtgDatos.Rows[i].Cells[0].Value;
                        ddc.preciou = Convert.ToDouble(dtgDatos.Rows[i].Cells[1].Value);
                        ddc.cantidad = Convert.ToInt32(this.dtgDatos.Rows[i].Cells[2].Value);
                        ddc.monto = Convert.ToDouble(this.dtgDatos.Rows[i].Cells[3].Value); ;

                        drp.Datos.Add(ddc);
                    }
                    drp.Show();
                }
            }
            else
            {
                MessageBox.Show("Faltan datos, por favor revise");
            }

            
        }

        private void dtgVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblCodigo.Text = dtgVentas.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
