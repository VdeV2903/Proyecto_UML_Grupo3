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
    public partial class frmReportes : Form
    {
        public frmReportes()
        {
            InitializeComponent();
        }

        private void frmReportes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ProductosSistema.Productos' Puede moverla o quitarla según sea necesario.
            this.ProductosTableAdapter.Fill(this.ProductosSistema.Productos);

            this.reportViewer1.RefreshReport();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.ProductosTableAdapter.Fill(this.ProductosSistema.Productos);

            this.reportViewer1.RefreshReport();
        }
    }
}
