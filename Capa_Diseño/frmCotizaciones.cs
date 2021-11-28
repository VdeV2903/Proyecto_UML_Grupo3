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
    public partial class frmCotizaciones : Form
    {
        Clientes cl = new Clientes();
        Productos pd = new Productos();
        Session ss = new Session();
        Cotizaciones ct = new Cotizaciones();
        frmFacturaCotizacion fct = new frmFacturaCotizacion();
        public frmCotizaciones()
        {
            InitializeComponent();
        }

        private void frmCotizaciones_Load(object sender, EventArgs e)
        {
            load();
        }
        public void load()
        {
            dtgClientesV.DataSource = cl.ventaClientes("");
            dtgProdsV.DataSource = pd.ventaProductos("");
            cargarListaCots();
        }
        private void cargarListaCots()
        {
            dtgLista.DataSource = ct.verCotizaciones(txtBuscar.Text);
        }
        private void txtNombreProd_TextChanged(object sender, EventArgs e)
        {
            dtgClientesV.DataSource = cl.ventaClientes(txtNombreProd.Text);
        }

        private void txtProdsV_TextChanged(object sender, EventArgs e)
        {
            dtgProdsV.DataSource = pd.ventaProductos(txtProdsV.Text);
        }

        private void dtgProdsV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblProd.Text = dtgProdsV.Rows[row2].Cells[0].Value.ToString();
        }
        private int cantidad = 0,row2 = 0,row = 0;
        private string nombre = "",marcap="";
        private int row3= 0;
        private double remove = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            if(dtgCarrito.Rows.Count == 0)
            {
                return;
            }
            row3 = dtgCarrito.CurrentRow.Index;


            remove = Convert.ToDouble(lblTotal.Text);
            lblTotal.Text = Convert.ToString(remove - Convert.ToDouble(dtgCarrito.Rows[row3].Cells[4].Value));
            total = total - Convert.ToDouble(dtgCarrito.Rows[row3].Cells[4].Value);
            dtgCarrito.Rows.RemoveAt(dtgCarrito.CurrentRow.Index);
        }

        private void dtgClientesV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = dtgClientesV.CurrentRow.Index;
            lblNombreC.Text = dtgClientesV.Rows[row].Cells[0].Value.ToString();
            lblTelefono.Text = dtgClientesV.Rows[row].Cells[1].Value.ToString();
            lblCorreo.Text = dtgClientesV.Rows[row].Cells[2].Value.ToString();
        }
        private void limpiarDatosCots()
        {
            lblNombreC.Text = "---";
            lblTelefono.Text = "---";
            lblCorreo.Text = "---";
            lblTotal.Text = "0";
            nupCantidad.Value = 1;
            dtgCarrito.Rows.Clear();
            total = 0;
            codigoventa = "";

        }
        private double precio = 0, subtotal = 0,total = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            row2 = dtgProdsV.CurrentRow.Index;
            subtotal = 0;
            nombre = dtgProdsV.Rows[row2].Cells[0].Value.ToString();
            precio = Convert.ToDouble(dtgProdsV.Rows[row2].Cells[2].Value);
            subtotal = (Convert.ToInt32(nupCantidad.Value)) * (Convert.ToDouble(precio));
            marcap = dtgProdsV.Rows[row2].Cells[1].Value.ToString();
            
            int n = dtgCarrito.Rows.Add();
            dtgCarrito.Rows[n].Cells[0].Value = nombre;
            dtgCarrito.Rows[n].Cells[1].Value = marcap;
            dtgCarrito.Rows[n].Cells[2].Value = precio;
            dtgCarrito.Rows[n].Cells[3].Value = nupCantidad.Value;  //numericupdown
            dtgCarrito.Rows[n].Cells[4].Value = subtotal;

            total = total + subtotal;
            lblTotal.Text = total.ToString();
        }
        DateTime now = DateTime.Now;
        private void setFecha()
        {
            fecha = now.ToString("yyyyMMdd");    //fecha
            hora = now.ToString("HHmmss");
            fechaconcat = fecha + "_" + hora;
        }
        private string fecha = "", hora = "", nombreg = "", nombregR = "", codigoventa = "";
        private bool reg = true;
        private void btnCotizar_Click(object sender, EventArgs e)
        {
            codigoventa = "";
            reg = crearCotizacion();
            if (reg == true)
            {
                cargarListaCots();
                limpiarDatosCots();
                fct.Show();
            }
        }

        private string correoRegVenta = "", nombreVendedor = "", fechaconcat = "";
        private double pagadoactual = 0, adeudo = 0.00, subtotalV = 0, totalV = 0, totalA = 0,precioIns = 0;
        private string nombreProdIns = "", marcaProdIns = "";
        private int cantidadProdIns = 0;
        private double subtotalProdIns = 0;
        private bool crearCotizacion()
        {
            bool okv = true;
            //codigoventa,fecha,subtotal,total,adeudo,fechapago,pagadoactual,id_cliente,correo,vendedor
            setFecha();
            nombreg = lblNombreC.Text; //cliente
            nombregR = nombreg.Substring(0, 3);
            correoRegVenta = lblCorreo.Text;    //correo
            codigoventa = nombregR + fechaconcat;  //codigoventa
            subtotalV = Math.Round(Convert.ToDouble(lblTotal.Text), 2); //subtotal //total
            nombreVendedor = ss.getNombre(); //vendedor

            
            totalA = subtotalV - adeudo; //solo para generar factura

            if (nombreg == "---")
            {
                MessageBox.Show("Debe elegir un cliente");
                okv = false;
            }
            else
            {
                if (dtgCarrito.Rows.Count == 0)
                {
                    MessageBox.Show("No se agregaron productos");
                    okv = false;
                }
                else
                {
                    fct.setCodigo(codigoventa);
                    //string codigo,string fecha,double subtotal,double total,double adeudo,string fechap,double pagado,string cliente,string vendedor
                    ct.insertarCotizacion(codigoventa, fecha, subtotalV, subtotalV, nombreg, correoRegVenta, nombreVendedor);

                    if (dtgCarrito.Rows.Count > 0)
                    {
                        foreach (DataGridViewRow row in dtgCarrito.Rows)
                        {
                            nombreProdIns = row.Cells[0].Value.ToString();
                            marcaProdIns = row.Cells[1].Value.ToString();
                            precioIns = Convert.ToDouble(row.Cells[2].Value);
                            cantidadProdIns = Convert.ToInt32(row.Cells[3].Value);
                            subtotalProdIns = Convert.ToDouble(row.Cells[4].Value);

                            ct.insertarProductosCot(nombreProdIns, marcaProdIns, codigoventa, precioIns,cantidadProdIns, subtotalProdIns);


                        }
                        
                    }
                    else
                    {

                    }
                    okv = true;

                }
            }
            return okv;
        }
    }
}
