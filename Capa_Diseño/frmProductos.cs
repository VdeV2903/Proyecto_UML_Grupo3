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
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();
        }
        Categorias ct = new Categorias();
        Productos pd = new Productos();
        private void frmProductos_Load(object sender, EventArgs e)
        {
            renovaredit();
            llenarDtgCat();
            dtgCats.RowHeadersVisible = false;
            dtgListaProds.RowHeadersVisible = false;
            cmbCatEditar.SelectedIndex = 0;
            lblOKingresarcat.Visible = false;
            lblEditarCat.Visible = false;
            llenarProductos();
            cargarCats();
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

        private void llenarDtgCat()
        {
            dtgCats.DataSource = ct.verCategorias();
        }
        private bool VerificarCat()
        {
            bool vr = true;
            if (string.IsNullOrEmpty(txtNombreCat.Text))
            {
                vr = false;
            }

            return vr;
        }
        private bool VerificarCatEdit()
        {
            bool vre = true;
            if (string.IsNullOrEmpty(txtNombreCatEdit.Text))
            {
                vre = false;
            }

            return vre;
        }
        public void limpiarCats()
        {
            txtNombreCat.Clear();
            txtNombreCatEdit.Clear();
        }
        private string ID = "";
        private string nombreCat = "", verificarExistCat = "";
        private void crearCategoria()
        {
            lblOKingresarcat.Visible = false;

            if (VerificarCat())
            {
                verificarExistCat = ct.verificarCategoria(txtNombreCat.Text);
                if (verificarExistCat == "")
                {
                    nombreCat = txtNombreCat.Text;
                    ct.insertarCategoria(nombreCat);

                    lblOKingresarcat.Text = "Categoria ingresada con exito";
                    lblOKingresarcat.ForeColor = Color.Green;
                    lblOKingresarcat.Visible = true;
                    llenarDtgCat();
                    limpiarCats();
                    cargarCats();
                }
                else
                {
                    lblOKingresarcat.Text = "La categoria ya existe";
                    lblOKingresarcat.ForeColor = Color.Red;
                    lblOKingresarcat.Visible = true;
                }
            }
            else
            {
                lblOKingresarcat.Text = "Ingrese el nombre";
                lblOKingresarcat.ForeColor = Color.Red;
                lblOKingresarcat.Visible = true;
            }
        }
        private string estado = "";
        private int row = 0;
        private void modificarCategoria()
        {
            lblEditarCat.Visible = false;
            if (VerificarCatEdit())
            {
                nombreCat = txtNombreCatEdit.Text;
                estado = cmbCatEditar.Text;

                ct.modificarCategoria(ID, nombreCat, estado);

                lblEditarCat.Text = "Categoria modificada con exito";
                lblEditarCat.ForeColor = Color.Green;
                lblEditarCat.Visible = true;
                llenarDtgCat();
                limpiarCats();
                cargarCats();
                ID = "";
            }
            else
            {
                lblEditarCat.Text = "Seleccione un registro";
                lblEditarCat.ForeColor = Color.Red;
                lblEditarCat.Visible = true;
            }
        }
        private void cargarCats()
        {
            cmbCategoria.ValueMember = "Nombre_Categoria";
            cmbCatEdit.ValueMember = "Nombre_Categoria";
            cmbCategoria.DataSource = ct.cargarCategorias();
            cmbCatEdit.DataSource = ct.cargarCategorias();
        }
        private void btnGuardarCategoria_Click(object sender, EventArgs e)
        {
            VerificarCat();
            crearCategoria();
        }

        private void btnActualizarCat_Click(object sender, EventArgs e)
        {
            VerificarCatEdit();
            modificarCategoria();
        }

        private void dtgCats_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblEditarCat.Visible = false;
            row = dtgCats.CurrentRow.Index;

            ID = dtgCats.Rows[row].Cells[0].Value.ToString();
            txtNombreCatEdit.Text = dtgCats.Rows[row].Cells[1].Value.ToString();
            cmbCatEditar.SelectedItem = dtgCats.Rows[row].Cells[2].Value.ToString();
        }

        private void eliminarCategoria()
        {
            lblEditarCat.Visible = false;
            if (ID != "")
            {
                ct.eliminarCategoria(ID);
                MessageBox.Show("Se deshabilitó la categoria");
                ID = "";
                llenarDtgCat();
                limpiarCats();
                cargarCats();
            }
            else
            {
                lblEditarCat.Text = "Seleccione un registro";
                lblEditarCat.ForeColor = Color.Red;
                lblEditarCat.Visible = true;
            }
        }

        private bool verificarProdIns()
        {
            bool ok = true;
            if (string.IsNullOrEmpty(txtNombreProd.Text))
            {
                ok = false;
            }
            if (string.IsNullOrEmpty(txtMarcaProd.Text))
            {
                ok = false;
            }
            if (string.IsNullOrEmpty(txtDistribuidorProd.Text))
            {
                ok = false;
            }
            if (string.IsNullOrEmpty(txtPrecioCompra.Text))
            {
                ok = false;
            }
            if (string.IsNullOrEmpty(txtPrecioVenta.Text))
            {
                ok = false;
            }
            return ok;
        }
        private void llenarProductos()
        {
            dtgListaProds.DataSource = pd.verProductos();
        }
        private string nombreIns = "", marcaIns = "", proveedorIns = "", catIns = "", precioc_Ins = "", precioventaIns = "";
       
        private void btnGuardarProd_Click(object sender, EventArgs e)
        {
            insertarProducto();
        }
        private string veriProd = "";
        private void insertarProducto()
        {
            lblErrorProd.Visible = false;

            nombreIns = txtNombreProd.Text;
            marcaIns = txtMarcaProd.Text;
            proveedorIns = txtDistribuidorProd.Text;
            catIns = cmbCategoria.Text;
            precioc_Ins = txtPrecioCompra.Text;
            precioventaIns = txtPrecioVenta.Text;

            if (verificarProdIns())
            {
                veriProd = pd.verificarProducto(nombreIns,marcaIns);

                if(veriProd == "")
                {
                    pd.insertarProducto(nombreIns, marcaIns, proveedorIns, catIns, precioc_Ins, precioventaIns);
                    llenarProductos();

                    lblErrorProd.Text = "Producto Insertado con Exito";
                    lblErrorProd.ForeColor = Color.Green;
                    lblErrorProd.Visible = true;
                }
                else
                {
                    lblErrorProd.Text = "El producto ya existe";
                    lblErrorProd.ForeColor = Color.Red;
                    lblErrorProd.Visible = true;
                }
            }
            else
            {
                lblErrorProd.Text = "Ingrese Todos los datos";
                lblErrorProd.ForeColor = Color.Red;
                lblErrorProd.Visible = true;
            }
        }
    }
}
