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
    public partial class frmPromociones : Form
    {
        Productos pd = new Productos();
        Promociones pr = new Promociones();
        public frmPromociones()
        {
            InitializeComponent();
        }

        private void frmPromociones_Load(object sender, EventArgs e)
        {
            listarProductos();
            listarPromos();
        }

        private void listarProductos()
        {
            dtgCrear.DataSource = pd.promocionProductos(txtProdsV.Text);
        }
        private void listarPromos()
        {
            dtgPromosA.DataSource = pr.listaPromos(txtBuscar.Text);
        }
        private void dtgCrear_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dtgCrear.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = dtgCrear.CurrentRow.Cells[1].Value.ToString();
            txtPrecioA.Text = dtgCrear.CurrentRow.Cells[3].Value.ToString();
            calcularDesc();
            txtPorce.Enabled = true;
        }
        private double precion = 0,descuento = 0;
        private int sentinela = 0;
        private void txtPorce_TextChanged(object sender, EventArgs e)
        {
            if (sentinela == 0)
            {
                calcularDesc();
            }
        }
        private bool verificarDatos()
        {
            bool ok = true;
            if (String.IsNullOrEmpty(txtID.Text))
            {
                ok = false;
            }
            if (String.IsNullOrEmpty(txtNombre.Text))
            {
                ok = false;
            }
            if (String.IsNullOrEmpty(txtPrecioA.Text))
            {
                ok = false;
            }
            if (String.IsNullOrEmpty(txtPorce.Text))
            {
                ok = false;
            }
            
            return ok;
        }
        private void limpiarDatos()
        {
            txtID.Clear();
            txtNombre.Clear();
            txtPrecioA.Clear();
            txtPorce.Text = "0.00";
            txtPrecioN.Clear();
            dtpFin.Value = DateTime.Today;
        }
        private int ID;
        private string nombre, fechafin;
        private double precioa, precionn,porce;
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            lblOK.Visible = false;
            
            if (verificarDatos())
            {
                if (Convert.ToDouble(txtPorce.Text) <= 0)
                {

                    lblOK.Text = "El porcentaje no debe ser 0 o negativo";
                    lblOK.ForeColor = Color.Red;
                    lblOK.Visible = true;
                    return;
                }
                else
                {
                    ID = Convert.ToInt32(txtID.Text);
                    nombre = txtNombre.Text;
                    fechafin = dtpFin.Value.ToString("yyyyMMdd");
                    precioa = Convert.ToDouble(txtPrecioA.Text);
                    porce = Convert.ToDouble(txtPorce.Text);
                    precionn = Convert.ToDouble(txtPrecioN.Text);

                    pr.crearPromo(ID,nombre,fechafin,precioa,porce, precionn);
                    lblOK.Text = "Promoción Creada";
                    lblOK.ForeColor = Color.Green;
                    lblOK.Visible = true;


                    listarPromos();
                    sentinela = 1;
                    limpiarDatos();
                    sentinela = 0;
                }

            }
            else
            {
                lblOK.Text = "Seleccione un registro";
                lblOK.ForeColor = Color.Red;
                lblOK.Visible = true;
            }


        }

        private void txtProdsV_TextChanged(object sender, EventArgs e)
        {
            listarProductos();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            listarPromos();
        }

        public void calcularDesc()
        {
            descuento = (Convert.ToDouble(txtPrecioA.Text) / 100) * Convert.ToDouble(txtPorce.Text);
            precion = Convert.ToDouble(txtPrecioA.Text) - descuento;

            txtPrecioN.Text = Math.Round(precion,2).ToString();
        }
    }
}
