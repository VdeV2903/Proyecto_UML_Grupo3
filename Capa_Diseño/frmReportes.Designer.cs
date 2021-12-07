
namespace Capa_Diseño
{
    partial class frmReportes
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
            this.reporteVentasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Tec_Shop_UMLG3DataSet2 = new Capa_Diseño.Tec_Shop_UMLG3DataSet2();
            this.label6 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ProductosSistema = new Capa_Diseño.ProductosSistema();
            this.ProductosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProductosTableAdapter = new Capa_Diseño.ProductosSistemaTableAdapters.ProductosTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.reporteVentasTableAdapter = new Capa_Diseño.Tec_Shop_UMLG3DataSet2TableAdapters.reporteVentasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.reporteVentasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tec_Shop_UMLG3DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductosSistema)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reporteVentasBindingSource
            // 
            this.reporteVentasBindingSource.DataMember = "reporteVentas";
            this.reporteVentasBindingSource.DataSource = this.Tec_Shop_UMLG3DataSet2;
            // 
            // Tec_Shop_UMLG3DataSet2
            // 
            this.Tec_Shop_UMLG3DataSet2.DataSetName = "Tec_Shop_UMLG3DataSet2";
            this.Tec_Shop_UMLG3DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(434, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 20);
            this.label6.TabIndex = 28;
            this.label6.Text = "Generar Reporte";
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "reporteVentas";
            reportDataSource1.Value = this.reporteVentasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Capa_Diseño.ReporteMensual.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 114);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1065, 511);
            this.reportViewer1.TabIndex = 29;
            // 
            // ProductosSistema
            // 
            this.ProductosSistema.DataSetName = "ProductosSistema";
            this.ProductosSistema.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ProductosBindingSource
            // 
            this.ProductosBindingSource.DataMember = "Productos";
            this.ProductosBindingSource.DataSource = this.ProductosSistema;
            // 
            // ProductosTableAdapter
            // 
            this.ProductosTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(25, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 39);
            this.button1.TabIndex = 58;
            this.button1.Text = "Ventas Mensuales";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(197, 69);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 39);
            this.button2.TabIndex = 59;
            this.button2.Text = "Ventas Semanales";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // reporteVentasTableAdapter
            // 
            this.reporteVentasTableAdapter.ClearBeforeFill = true;
            // 
            // frmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1066, 626);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1066, 626);
            this.MinimumSize = new System.Drawing.Size(1066, 626);
            this.Name = "frmReportes";
            this.Text = "frmReportes";
            this.Load += new System.EventHandler(this.frmReportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reporteVentasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tec_Shop_UMLG3DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductosSistema)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ProductosBindingSource;
        private ProductosSistema ProductosSistema;
        private ProductosSistemaTableAdapters.ProductosTableAdapter ProductosTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource reporteVentasBindingSource;
        private Tec_Shop_UMLG3DataSet2 Tec_Shop_UMLG3DataSet2;
        private Tec_Shop_UMLG3DataSet2TableAdapters.reporteVentasTableAdapter reporteVentasTableAdapter;
    }
}