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
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            renovaredit();
        }
        public void renovarinsert()
        {
            txtNombreProd.Clear();
            cmbCategoria.SelectedItem = 0;
            txtMarcaProd.Clear();
            txtDistribuidorProd.Clear();
            txtPrecioCompra.Clear();
            txtPrecioVenta.Clear();
        }
        public void renovaredit()
        {
            ckNombre.Checked = false;
            ckCategoria.Checked = false;
            ckMarca.Checked = false;
            ckDistribuidor.Checked = false;
            ckCompra.Checked = false;
            ckVenta.Checked = false;

            txtNombreEdit.Enabled = false;
            txtMarcaEdit.Enabled = false;
            txtDistriEdit.Enabled = false;
            txtCompraEdit.Enabled = false;
            txtVentaEdit.Enabled = false;

            txtNombreEdit.Clear();
            cmbCatEdit.SelectedItem = 0;
            txtMarcaEdit.Clear();
            txtDistriEdit.Clear();
            txtCompraEdit.Clear();
            txtVentaEdit.Clear();
        }
        public void checktodo()
        {
            if (ckTodo.Checked == true)
            {
                ckNombre.Checked = true;
                ckCategoria.Checked = true;
                ckMarca.Checked = true;
                ckDistribuidor.Checked = true;
                ckCompra.Checked = true;
                ckVenta.Checked = true;
            }
            else
            {
                ckNombre.Checked = false;
                ckCategoria.Checked = false;
                ckMarca.Checked = false;
                ckDistribuidor.Checked = false;
                ckCompra.Checked = false;
                ckVenta.Checked = false;
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
            if (ckCategoria.Checked == true)
            {
                cmbCatEdit.Enabled = true;
            }
            else
            {
                cmbCatEdit.Enabled = false;
                ckTodo.Checked = false;
            }
            if (ckMarca.Checked == true)
            {
                txtMarcaEdit.Enabled = true;
            }
            else
            {
                txtMarcaEdit.Enabled = false;
                ckTodo.Checked = false;
            }
            if (ckDistribuidor.Checked == true)
            {
                txtDistriEdit.Enabled = true;
            }
            else
            {
                txtDistriEdit.Enabled = false;
                ckTodo.Checked = false;
            }
            if (ckCompra.Checked == true)
            {
                txtCompraEdit.Enabled = true;
            }
            else
            {
                txtCompraEdit.Enabled = false;
                ckTodo.Checked = false;
            }
            if (ckVenta.Checked == true)
            {
                txtVentaEdit.Enabled = true;
            }
            else
            {
                txtVentaEdit.Enabled = false;
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

        private void ckCategoria_Click(object sender, EventArgs e)
        {
            desbloqueartxt();
        }

        private void ckMarca_Click(object sender, EventArgs e)
        {
            desbloqueartxt();
        }

        private void ckDistribuidor_Click(object sender, EventArgs e)
        {
            desbloqueartxt();
        }

        private void ckCompra_Click(object sender, EventArgs e)
        {
            desbloqueartxt();
        }

        private void ckVenta_Click(object sender, EventArgs e)
        {
            desbloqueartxt();
        }
    }
}
