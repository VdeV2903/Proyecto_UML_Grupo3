using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Capa_Datos;

namespace Capa_Diseño
{
    public partial class frmDocumentoReporte : Form
    {
        public List<DatosDoc> Datos = new List<DatosDoc>();
        public frmDocumentoReporte()
        {
            InitializeComponent();
        }

        private void frmDocumentoReporte_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetDocRep",Datos));
            this.reportViewer1.RefreshReport();
        }
    }
}
