namespace Capas.UI.reporte
{
    partial class FrmEstudiantesMasSolicitaron
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
            this.PA_ReporteEstudiantesQueMasSolicitanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBLibrosEstudiantesMasSolicitan = new Capas.UI.DBLibrosEstudiantesMasSolicitan();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.header = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.labelHeader = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pAReporteEstudiantesQueMasSolicitanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pA_ReporteEstudiantesQueMasSolicitanTableAdapter = new Capas.UI.DBLibrosEstudiantesMasSolicitanTableAdapters.PA_ReporteEstudiantesQueMasSolicitanTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PA_ReporteEstudiantesQueMasSolicitanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBLibrosEstudiantesMasSolicitan)).BeginInit();
            this.panel4.SuspendLayout();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAReporteEstudiantesQueMasSolicitanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // PA_ReporteEstudiantesQueMasSolicitanBindingSource
            // 
            this.PA_ReporteEstudiantesQueMasSolicitanBindingSource.DataMember = "PA_ReporteEstudiantesQueMasSolicitan";
            this.PA_ReporteEstudiantesQueMasSolicitanBindingSource.DataSource = this.dBLibrosEstudiantesMasSolicitan;
            // 
            // dBLibrosEstudiantesMasSolicitan
            // 
            this.dBLibrosEstudiantesMasSolicitan.DataSetName = "DBLibrosEstudiantesMasSolicitan";
            this.dBLibrosEstudiantesMasSolicitan.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DsMasSolicitaron";
            reportDataSource1.Value = this.PA_ReporteEstudiantesQueMasSolicitanBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Capas.UI.reporte.reportEstudiantesQueMasSolicitaron.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, 80);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1051, 393);
            this.reportViewer1.TabIndex = 33;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Thistle;
            this.panel4.Controls.Add(this.label17);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 47);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1055, 33);
            this.panel4.TabIndex = 34;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(390, 10);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(383, 20);
            this.label17.TabIndex = 23;
            this.label17.Text = "Reporte Estudiantes que más solicitaron libros";
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
            this.header.Size = new System.Drawing.Size(1055, 47);
            this.header.TabIndex = 32;
            this.header.Paint += new System.Windows.Forms.PaintEventHandler(this.header_Paint);
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
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(1, 470);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1051, 46);
            this.panel1.TabIndex = 36;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.header;
            this.bunifuDragControl1.Vertical = true;
            // 
            // pAReporteEstudiantesQueMasSolicitanBindingSource
            // 
            this.pAReporteEstudiantesQueMasSolicitanBindingSource.DataMember = "PA_ReporteEstudiantesQueMasSolicitan";
            this.pAReporteEstudiantesQueMasSolicitanBindingSource.DataSource = this.dBLibrosEstudiantesMasSolicitan;
            // 
            // pA_ReporteEstudiantesQueMasSolicitanTableAdapter
            // 
            this.pA_ReporteEstudiantesQueMasSolicitanTableAdapter.ClearBeforeFill = true;
            // 
            // FrmEstudiantesMasSolicitaron
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 519);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEstudiantesMasSolicitaron";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estudiantes Mas Solicitaron";
            this.Load += new System.EventHandler(this.FrmEstudiantesMasSolicitaron_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PA_ReporteEstudiantesQueMasSolicitanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBLibrosEstudiantesMasSolicitan)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAReporteEstudiantesQueMasSolicitanBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel header;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private System.Windows.Forms.Label labelHeader;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private DBLibrosEstudiantesMasSolicitan dBLibrosEstudiantesMasSolicitan;
        private System.Windows.Forms.BindingSource pAReporteEstudiantesQueMasSolicitanBindingSource;
        private DBLibrosEstudiantesMasSolicitanTableAdapters.PA_ReporteEstudiantesQueMasSolicitanTableAdapter pA_ReporteEstudiantesQueMasSolicitanTableAdapter;
        private System.Windows.Forms.BindingSource PA_ReporteEstudiantesQueMasSolicitanBindingSource;
    }
}