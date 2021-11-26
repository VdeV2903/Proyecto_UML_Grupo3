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
            cargarListaVentas();
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
            total = 0;

        }
        private void cargarListaVentas()
        {
            dtgListaVentas.DataSource = vt.verVentas();
        }
        
        private string fecha = "",hora = "",nombreg = "",nombregR = "",codigoventa = "";
        private string correoRegVenta = "",nombreVendedor = "",fechaconcat = "";
        private double pagadoactual = 0,adeudo = 0.00,subtotalV = 0,totalV = 0,totalA=0;
        private int row3 = 0;
        private double remove;
        private void button2_Click(object sender, EventArgs e)
        {
            row3 = dtgCarrito.CurrentRow.Index;

            remove = Convert.ToDouble(lblTotal.Text);
            lblTotal.Text = Convert.ToString( remove - Convert.ToDouble(dtgCarrito.Rows[row].Cells[4].Value));
            total = total - Convert.ToDouble(dtgCarrito.Rows[row].Cells[4].Value);
            dtgCarrito.Rows.RemoveAt(dtgCarrito.CurrentRow.Index);
        }
        DateTime now = DateTime.Now;
        private void setFecha()
        {
            fecha = now.ToString("yyyyMMdd");    //fecha
            hora = now.ToString("HHmmss");
            fechaconcat = fecha + "_" + hora;
        }
        private bool crearVenta()
        {
            bool okv = true;
            //codigoventa,fecha,subtotal,total,adeudo,fechapago,pagadoactual,id_cliente,correo,vendedor
            setFecha();
            nombreg = lblNombreC.Text; //cliente
            nombregR = nombreg.Substring(0,3);
            correoRegVenta = lblCorreo.Text;    //correo
            codigoventa = nombregR + fechaconcat;  //codigoventa
            subtotalV = Math.Round(Convert.ToDouble(lblTotal.Text), 2); //subtotal //total
            nombreVendedor = ss.getNombre(); //vendedor

            MessageBox.Show(codigoventa);
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
                    MessageBox.Show("_"+subtotalV + "_");
                    //string codigo,string fecha,double subtotal,double total,double adeudo,string fechap,double pagado,string cliente,string vendedor
                    vt.insertarVenta(codigoventa,fecha,subtotalV, subtotalV,nombreg,correoRegVenta,nombreVendedor);

                    if (dtgCarrito.Rows.Count > 0)
                    {
                        foreach (DataGridViewRow row in dtgCarrito.Rows)
                        {
                            nombreProdIns = row.Cells[0].Value.ToString();
                            marcaProdIns = row.Cells[1].Value.ToString();
                            //precioProdIns = Convert.ToDouble(row.Cells[2].Value);
                            cantidadProdIns = Convert.ToInt32(row.Cells[3].Value);
                            subtotalProdIns = Convert.ToDouble(row.Cells[4].Value);

                            vt.insertarProductosVenta(nombreProdIns, marcaProdIns, codigoventa, cantidadProdIns, subtotalProdIns);


                        }
                        MessageBox.Show("Datos agregados");
                    }
                    else
                    {

                    }
                    okv = true;

                }  
            }
            return okv;
        }
        private double precio = 0,subtotal = 0;
        private string nombre = "",marcap = "";
        private bool reg = true;
        private void button3_Click(object sender, EventArgs e)
        {
            codigoventa = "";
            reg = crearVenta(); 
            if(reg == true)
            {
                cargarListaVentas();
                limpiarDatosVenta();
                MessageBox.Show("VENTA COMPLETADA, GENERAR FACTURA");
            }
            
            
                    
        }

        private double total = 0;
        private void btnAnadir_Click(object sender, EventArgs e)
        {
            subtotal = 0;
            nombre = dtgProductos.Rows[row2].Cells[0].Value.ToString();
            precio = Convert.ToDouble(dtgProductos.Rows[row2].Cells[2].Value);
            subtotal = (Convert.ToInt32(nudCantidad.Value)) * (Convert.ToDouble(precio));
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

                    vt.insertarProductosVenta(nombreProdIns, marcaProdIns,codigoventa, cantidadProdIns, subtotalProdIns);


                }
                MessageBox.Show("Datos agregados");
            }
            else
            {

            }
                
            
        }
    }
}
