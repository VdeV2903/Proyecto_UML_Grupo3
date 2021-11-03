using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Capa_Diseño
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            dtgLista.RowHeadersVisible = false;
            dtgEditar.RowHeadersVisible = false;
            cmbFiltro.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFiltro.SelectedIndex = 0;
            cmbEditar.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEditar.SelectedIndex = 0;
        }
        
    }
}
