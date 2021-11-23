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
    public partial class frmVentas : Form
    {
        public frmVentas()
        {
            InitializeComponent();
        }
        Clientes cl = new Clientes();
        Productos PD = new Productos();
        private void frmVentas_Load(object sender, EventArgs e)
        {
            dtgClientes.DataSource = cl.ventaClientes();
            dtgProductos.DataSource = PD.ventaProductos();
        }
        private int row = 0,row2 = 0;
        private void dtgClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = dtgClientes.CurrentRow.Index;
            lblNombreC.Text = dtgClientes.Rows[row].Cells[0].Value.ToString();
            lblTelefono.Text = dtgClientes.Rows[row].Cells[1].Value.ToString();
            lblCorreo.Text = dtgClientes.Rows[row].Cells[2].Value.ToString();
        }

        private void dtgProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            row2 = dtgProductos.CurrentRow.Index;
            lblProd.Text = dtgProductos.Rows[row2].Cells[0].Value.ToString();
        }
        private double precio = 0,subtotal = 0;
        private int cantidad = 0;
        private string nombre = "",marcap = "";

        private void button3_Click(object sender, EventArgs e)
        {
            int r = dtgListaVentas.Rows.Add();
            dtgListaVentas.Rows[r].Cells[0].Value = lblNombreC.Text;
            dtgListaVentas.Rows[r].Cells[1].Value = "Marcos Medina";
            dtgListaVentas.Rows[r].Cells[2].Value = "21/11/21";  //numericupdown
            dtgListaVentas.Rows[r].Cells[3].Value = lblTotal.Text;



            lblNombreC.Text = "---";
            lblTelefono.Text = "---";
            lblCorreo.Text = "---";
            lblTotal.Text = "0";
            nudCantidad.Value = 1;
            dtgCarrito.Rows.Clear();

            MessageBox.Show("VENTA COMPLETADA, GENERAR FACTURA");

        }

        private double total = 0;
        private void btnAnadir_Click(object sender, EventArgs e)
        {
            nombre = dtgProductos.Rows[row2].Cells[0].Value.ToString();
            precio = Convert.ToDouble(dtgProductos.Rows[row2].Cells[2].Value);
            subtotal = (Convert.ToDouble(nudCantidad.Value)) * (Convert.ToDouble(precio));
            marcap = dtgProductos.Rows[row2].Cells[1].Value.ToString();

            int n = dtgCarrito.Rows.Add();
            dtgCarrito.Rows[n].Cells[0].Value = nombre;
            dtgCarrito.Rows[n].Cells[1].Value = marcap;
            dtgCarrito.Rows[n].Cells[2].Value = precio;
            dtgCarrito.Rows[n].Cells[3].Value = nudCantidad.Value;  //numericupdown
            dtgCarrito.Rows[n].Cells[4].Value = subtotal;

            total = total + subtotal;
            lblTotal.Text = total.ToString();
        }
    }
}
