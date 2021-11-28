
namespace Capa_Diseño
{
    partial class frmFactura
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label6 = new System.Windows.Forms.Label();
            this.Tec_Shop_UMLG3DataSet = new Capa_Diseño.Tec_Shop_UMLG3DataSet();
            this.generarFacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.generarFacturaTableAdapter = new Capa_Diseño.Tec_Shop_UMLG3DataSetTableAdapters.generarFacturaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Tec_Shop_UMLG3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generarFacturaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "Factura";
            reportDataSource2.Value = this.generarFacturaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Capa_Diseño.Factura.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-1, 42);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(974, 522);
            this.reportViewer1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(389, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 20);
            this.label6.TabIndex = 29;
            this.label6.Text = "Generar Factura";
            // 
            // Tec_Shop_UMLG3DataSet
            // 
            this.Tec_Shop_UMLG3DataSet.DataSetName = "Tec_Shop_UMLG3DataSet";
            this.Tec_Shop_UMLG3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // generarFacturaBindingSource
            // 
            this.generarFacturaBindingSource.DataMember = "generarFactura";
            this.generarFacturaBindingSource.DataSource = this.Tec_Shop_UMLG3DataSet;
            // 
            // generarFacturaTableAdapter
            // 
            this.generarFacturaTableAdapter.ClearBeforeFill = true;
            // 
            // frmFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 563);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.reportViewer1);
            this.MaximumSize = new System.Drawing.Size(989, 602);
            this.MinimumSize = new System.Drawing.Size(989, 602);
            this.Name = "frmFactura";
            this.Text = "frmFactura";
            this.Load += new System.EventHandler(this.frmFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Tec_Shop_UMLG3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generarFacturaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource generarFacturaBindingSource;
        private Tec_Shop_UMLG3DataSet Tec_Shop_UMLG3DataSet;
        private System.Windows.Forms.Label label6;
        private Tec_Shop_UMLG3DataSetTableAdapters.generarFacturaTableAdapter generarFacturaTableAdapter;
    }
}