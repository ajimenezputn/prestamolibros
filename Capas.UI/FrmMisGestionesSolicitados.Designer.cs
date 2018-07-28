namespace Capas.UI
{
    partial class FrmMisGestionesSolicitados
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
            this.PA_LibrosSolicitadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DBLibrosDataSet2 = new Capas.UI.DBLibrosDataSet2();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PA_LibrosSolicitadosTableAdapter = new Capas.UI.DBLibrosDataSet2TableAdapters.PA_LibrosSolicitadosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PA_LibrosSolicitadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBLibrosDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // PA_LibrosSolicitadosBindingSource
            // 
            this.PA_LibrosSolicitadosBindingSource.DataMember = "PA_LibrosSolicitados";
            this.PA_LibrosSolicitadosBindingSource.DataSource = this.DBLibrosDataSet2;
            // 
            // DBLibrosDataSet2
            // 
            this.DBLibrosDataSet2.DataSetName = "DBLibrosDataSet2";
            this.DBLibrosDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DsLibrosSolicitados";
            reportDataSource1.Value = this.PA_LibrosSolicitadosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Capas.UI.reporte.ReportLibrosSolicitadosGestion.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(581, 461);
            this.reportViewer1.TabIndex = 1;
            // 
            // PA_LibrosSolicitadosTableAdapter
            // 
            this.PA_LibrosSolicitadosTableAdapter.ClearBeforeFill = true;
            // 
            // FrmMisGestionesSolicitados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 461);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmMisGestionesSolicitados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Libros Solicitados";
            this.Load += new System.EventHandler(this.FrmMisGestiones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PA_LibrosSolicitadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBLibrosDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PA_LibrosSolicitadosBindingSource;
        private DBLibrosDataSet2 DBLibrosDataSet2;
        private DBLibrosDataSet2TableAdapters.PA_LibrosSolicitadosTableAdapter PA_LibrosSolicitadosTableAdapter;
    }
}