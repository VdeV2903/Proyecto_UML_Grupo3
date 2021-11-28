
namespace Capa_Diseño
{
    partial class frmFacturaCotizacion
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.datosCotizacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Tec_Shop_UMLG3DataSet1 = new Capa_Diseño.Tec_Shop_UMLG3DataSet1();
            this.generarFacturaCotizacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.generarFacturaCotizacionTableAdapter = new Capa_Diseño.Tec_Shop_UMLG3DataSet1TableAdapters.generarFacturaCotizacionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.datosCotizacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tec_Shop_UMLG3DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generarFacturaCotizacionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(402, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 20);
            this.label6.TabIndex = 31;
            this.label6.Text = "Generar Cotización";
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "CotizacionesData";
            reportDataSource1.Value = this.generarFacturaCotizacionBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Capa_Diseño.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 42);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(972, 522);
            this.reportViewer1.TabIndex = 30;
            // 
            // Tec_Shop_UMLG3DataSet1
            // 
            this.Tec_Shop_UMLG3DataSet1.DataSetName = "Tec_Shop_UMLG3DataSet1";
            this.Tec_Shop_UMLG3DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // generarFacturaCotizacionBindingSource
            // 
            this.generarFacturaCotizacionBindingSource.DataMember = "generarFacturaCotizacion";
            this.generarFacturaCotizacionBindingSource.DataSource = this.Tec_Shop_UMLG3DataSet1;
            // 
            // generarFacturaCotizacionTableAdapter
            // 
            this.generarFacturaCotizacionTableAdapter.ClearBeforeFill = true;
            // 
            // frmFacturaCotizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 563);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.reportViewer1);
            this.MaximumSize = new System.Drawing.Size(989, 602);
            this.MinimumSize = new System.Drawing.Size(989, 602);
            this.Name = "frmFacturaCotizacion";
            this.Text = "frmFacturaCotizacion";
            this.Load += new System.EventHandler(this.frmFacturaCotizacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datosCotizacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tec_Shop_UMLG3DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generarFacturaCotizacionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource datosCotizacionBindingSource;
        private System.Windows.Forms.BindingSource generarFacturaCotizacionBindingSource;
        private Tec_Shop_UMLG3DataSet1 Tec_Shop_UMLG3DataSet1;
        private Tec_Shop_UMLG3DataSet1TableAdapters.generarFacturaCotizacionTableAdapter generarFacturaCotizacionTableAdapter;
    }
}