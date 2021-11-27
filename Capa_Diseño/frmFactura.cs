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
    public partial class frmFactura : Form
    {
        private string codigoventa = "";
        public frmFactura()
        {
            InitializeComponent();
        }
        public void setCodigo(string codigo)
        {
            codigoventa = codigo;
        }
        private void frmFactura_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'Tec_Shop_UMLG3DataSet.generarFactura' Puede moverla o quitarla según sea necesario.
            vcargar();
        }

        private void vcargar()
        {
            this.generarFacturaTableAdapter.Fill(this.Tec_Shop_UMLG3DataSet.generarFactura, codigoventa);

            this.reportViewer1.RefreshReport();
        }
    }
}
