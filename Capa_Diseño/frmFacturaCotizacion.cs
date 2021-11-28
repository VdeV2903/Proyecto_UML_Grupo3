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
    public partial class frmFacturaCotizacion : Form
    {
        public frmFacturaCotizacion()
        {
            InitializeComponent();
        }
        private string codigocot = "";
        public void setCodigo(string codigo)
        {
            codigocot = codigo;
        }

        private void frmFacturaCotizacion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'Tec_Shop_UMLG3DataSet1.generarFacturaCotizacion' Puede moverla o quitarla según sea necesario.
            this.generarFacturaCotizacionTableAdapter.Fill(this.Tec_Shop_UMLG3DataSet1.generarFacturaCotizacion,codigocot);

            this.reportViewer1.RefreshReport();
        }
    }
}
