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
        Productos pd = new Productos();
        Ventas vt = new Ventas();
        Session ss = new Session();
        private void frmVentas_Load(object sender, EventArgs e)
        {
            dtgClientes.DataSource = cl.ventaClientes();
            dtgProductos.DataSource = pd.ventaProductos();
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
        private void limpiarDatosVenta()
        {
            lblNombreC.Text = "---";
            lblTelefono.Text = "---";
            lblCorreo.Text = "---";
            lblTotal.Text = "0";
            nudCantidad.Value = 1;
            dtgCarrito.Rows.Clear();

        }
        DateTime now = DateTime.Now;
        private string fecha = "",hora = "",nombreg = "",nombregR = "",codigoventa = "";
        private string correoRegVenta = "",fechapago = "",nombreVendedor = "";
        private double pagadoactual = 0,adeudo = 0,subtotalV = 0,totalV = 0,totalA=0;
        
        private void crearVenta()
        {
            //codigoventa,fecha,subtotal,total,adeudo,fechapago,pagadoactual,id_cliente,vendedor
            fecha = now.ToString("yyyyMMdd");
            hora = now.ToString("HHmmss");
            nombreg = lblNombreC.Text;
            nombregR = nombreg.Substring(0,3);
            correoRegVenta = lblCorreo.Text;
            codigoventa = nombregR + fecha + "_" + hora;
            subtotalV = Convert.ToDouble(lblTotal.Text);

            if (nombreg == "---")
            {
                MessageBox.Show("Debe elegir un cliente");
                return;
            }
            else
            {
                if (dtgCarrito.Rows.Count == 0)
                {
                    MessageBox.Show("No se agregaron productos");
                    return;
                }
                else
                {
                    nombreVendedor = ss.getNombre();
                    pagadoactual = Convert.ToDouble(txtSaldar.Text);
                    fechapago = dtpAdeudo.Value.ToString("yyyyMMdd");
                    adeudo = subtotalV - pagadoactual;
                    totalV = subtotalV - adeudo;
                    MessageBox.Show(correoRegVenta);

                    vt.trarIDCliente(nombreg, correoRegVenta);
                    //string codigo,string fecha,double subtotal,double total,double adeudo,string fechap,double pagado,string cliente,string vendedor
                    vt.insertarVenta(codigoventa,fecha,subtotal,totalV,adeudo,fechapago,pagadoactual,nombreg,nombreVendedor,totalA);
                }  
            }

        }
        private double precio = 0,subtotal = 0;
        private string nombre = "",marcap = "";

        private void button3_Click(object sender, EventArgs e)
        {
            crearVenta();
            return;
            enviarProductos();
            limpiarDatosVenta();
            
              
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
        //string nombre,string marca,int cantidad,double subtotal
        private string nombreProdIns = "", marcaProdIns = "";
        private int cantidadProdIns = 0;
        private double subtotalProdIns = 0;
        public void enviarProductos()
        {
            if(dtgCarrito.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dtgCarrito.Rows)
                {
                    nombreProdIns = row.Cells[0].Value.ToString();
                    marcaProdIns = row.Cells[1].Value.ToString();
                    //precioProdIns = Convert.ToDouble(row.Cells[2].Value);
                    cantidadProdIns = Convert.ToInt32(row.Cells[3].Value);
                    subtotalProdIns = Convert.ToDouble(row.Cells[4].Value);

                    vt.insertarProductosVenta(nombreProdIns, marcaProdIns, cantidadProdIns, subtotalProdIns);


                }
                MessageBox.Show("Datos agregados");
            }
            else
            {

            }
                
            
        }
    }
}
