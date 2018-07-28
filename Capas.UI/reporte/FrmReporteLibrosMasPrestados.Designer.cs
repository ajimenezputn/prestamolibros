namespace Capas.UI.reporte
{
    partial class FrmReporteLibrosMasPrestados
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
            this.PA_ReporteLibrosMasPrestadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBLibrosmasPrestados = new Capas.UI.DBLibrosmasPrestados();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dBLibrosmasPrestadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pAReporteLibrosMasPrestadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pA_ReporteLibrosMasPrestadoTableAdapter = new Capas.UI.DBLibrosmasPrestadosTableAdapters.PA_ReporteLibrosMasPrestadoTableAdapter();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.header = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.labelHeader = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.PA_ReporteLibrosMasPrestadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBLibrosmasPrestados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBLibrosmasPrestadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAReporteLibrosMasPrestadoBindingSource)).BeginInit();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // PA_ReporteLibrosMasPrestadoBindingSource
            // 
            this.PA_ReporteLibrosMasPrestadoBindingSource.DataMember = "PA_ReporteLibrosMasPrestado";
            this.PA_ReporteLibrosMasPrestadoBindingSource.DataSource = this.dBLibrosmasPrestados;
            // 
            // dBLibrosmasPrestados
            // 
            this.dBLibrosmasPrestados.DataSetName = "DBLibrosmasPrestados";
            this.dBLibrosmasPrestados.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DsLibrosMasPrestados";
            reportDataSource2.Value = this.PA_ReporteLibrosMasPrestadoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Capas.UI.reporte.reporteLibrosMasPrestados.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 80);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1050, 393);
            this.reportViewer1.TabIndex = 2;
            // 
            // dBLibrosmasPrestadosBindingSource
            // 
            this.dBLibrosmasPrestadosBindingSource.DataSource = this.dBLibrosmasPrestados;
            this.dBLibrosmasPrestadosBindingSource.Position = 0;
            // 
            // pAReporteLibrosMasPrestadoBindingSource
            // 
            this.pAReporteLibrosMasPrestadoBindingSource.DataMember = "PA_ReporteLibrosMasPrestado";
            this.pAReporteLibrosMasPrestadoBindingSource.DataSource = this.dBLibrosmasPrestadosBindingSource;
            // 
            // pA_ReporteLibrosMasPrestadoTableAdapter
            // 
            this.pA_ReporteLibrosMasPrestadoTableAdapter.ClearBeforeFill = true;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.header;
            this.bunifuDragControl1.Vertical = true;
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.RoyalBlue;
            this.header.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.header.Controls.Add(this.bunifuImageButton1);
            this.header.Controls.Add(this.bunifuImageButton2);
            this.header.Controls.Add(this.labelHeader);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1053, 47);
            this.header.TabIndex = 1;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = global::Capas.UI.Properties.Resources.icons8_Minimize_Window_96px;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(943, -1);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(55, 48);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 29;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton2.Image = global::Capas.UI.Properties.Resources.icons8_Close_Window_96px;
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(995, -1);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(55, 48);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 28;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelHeader.Location = new System.Drawing.Point(18, 9);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(86, 24);
            this.labelHeader.TabIndex = 0;
            this.labelHeader.Text = "Reportes";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Thistle;
            this.panel4.Controls.Add(this.label17);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 47);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1053, 33);
            this.panel4.TabIndex = 30;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(412, 10);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(275, 20);
            this.label17.TabIndex = 23;
            this.label17.Text = "Reporte de libros más prestados ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(0, 468);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1051, 46);
            this.panel1.TabIndex = 31;
            // 
            // FrmReporteLibrosMasPrestados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 517);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmReporteLibrosMasPrestados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Libros Mas Prestados";
            this.Load += new System.EventHandler(this.FrmReporteLibrosMasPrestados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PA_ReporteLibrosMasPrestadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBLibrosmasPrestados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBLibrosmasPrestadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAReporteLibrosMasPrestadoBindingSource)).EndInit();
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DBLibrosmasPrestados dBLibrosmasPrestados;
        private System.Windows.Forms.BindingSource dBLibrosmasPrestadosBindingSource;
        private System.Windows.Forms.BindingSource pAReporteLibrosMasPrestadoBindingSource;
        private DBLibrosmasPrestadosTableAdapters.PA_ReporteLibrosMasPrestadoTableAdapter pA_ReporteLibrosMasPrestadoTableAdapter;
        private System.Windows.Forms.BindingSource PA_ReporteLibrosMasPrestadoBindingSource;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel header;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Panel panel1;
    }
}