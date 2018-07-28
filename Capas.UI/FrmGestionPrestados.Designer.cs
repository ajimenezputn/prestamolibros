namespace Capas.UI
{
    partial class FrmGestionPrestados
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
            this.DBLibrosDataSet3 = new Capas.UI.DBLibrosDataSet3();
            this.PA_LibrosPrestadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PA_LibrosPrestadosTableAdapter = new Capas.UI.DBLibrosDataSet3TableAdapters.PA_LibrosPrestadosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DBLibrosDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PA_LibrosPrestadosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DsGestionPrestados";
            reportDataSource2.Value = this.PA_LibrosPrestadosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Capas.UI.reporte.ReportGestionPrestados.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(572, 421);
            this.reportViewer1.TabIndex = 0;
            // 
            // DBLibrosDataSet3
            // 
            this.DBLibrosDataSet3.DataSetName = "DBLibrosDataSet3";
            this.DBLibrosDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PA_LibrosPrestadosBindingSource
            // 
            this.PA_LibrosPrestadosBindingSource.DataMember = "PA_LibrosPrestados";
            this.PA_LibrosPrestadosBindingSource.DataSource = this.DBLibrosDataSet3;
            // 
            // PA_LibrosPrestadosTableAdapter
            // 
            this.PA_LibrosPrestadosTableAdapter.ClearBeforeFill = true;
            // 
            // FrmGestionPrestados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 421);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmGestionPrestados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion Prestados";
            this.Load += new System.EventHandler(this.FrmGestionPrestados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DBLibrosDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PA_LibrosPrestadosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PA_LibrosPrestadosBindingSource;
        private DBLibrosDataSet3 DBLibrosDataSet3;
        private DBLibrosDataSet3TableAdapters.PA_LibrosPrestadosTableAdapter PA_LibrosPrestadosTableAdapter;
    }
}