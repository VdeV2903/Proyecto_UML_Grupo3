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
    public partial class frmEmpleados : Form
    {
        public frmEmpleados()
        {
            InitializeComponent();
        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            this.dtgLista.RowHeadersVisible = false;
            this.dtgEditar.RowHeadersVisible = false;
            cmbFiltro.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFiltro.SelectedIndex = 0;
            cmbEditar.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEditar.SelectedIndex = 0;
        }
    }
}
