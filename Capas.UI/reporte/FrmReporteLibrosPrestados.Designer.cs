namespace Capas.UI.reporte
{
    partial class FrmReporteLibrosPrestados
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
            this.PA_ReporteLibrosPrestadosHistoricoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBLibrosHistoricoLibros = new Capas.UI.DBLibrosHistoricoLibros();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.header = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.labelHeader = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBuscarEstudiantes = new Bunifu.Framework.UI.BunifuImageButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPrimerApellido = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSegundoApellido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreEst = new System.Windows.Forms.TextBox();
            this.mskCedulaEstudiante = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.reportViewerHistorico = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pAReporteLibrosPrestadosHistoricoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBLibrosHistoricoLibrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pA_ReporteLibrosPrestadosHistoricoTableAdapter = new Capas.UI.DBLibrosHistoricoLibrosTableAdapters.PA_ReporteLibrosPrestadosHistoricoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PA_ReporteLibrosPrestadosHistoricoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBLibrosHistoricoLibros)).BeginInit();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarEstudiantes)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pAReporteLibrosPrestadosHistoricoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBLibrosHistoricoLibrosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // PA_ReporteLibrosPrestadosHistoricoBindingSource
            // 
            this.PA_ReporteLibrosPrestadosHistoricoBindingSource.DataMember = "PA_ReporteLibrosPrestadosHistorico";
            this.PA_ReporteLibrosPrestadosHistoricoBindingSource.DataSource = this.dBLibrosHistoricoLibros;
            // 
            // dBLibrosHistoricoLibros
            // 
            this.dBLibrosHistoricoLibros.DataSetName = "DBLibrosHistoricoLibros";
            this.dBLibrosHistoricoLibros.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
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
            this.header.Size = new System.Drawing.Size(1059, 47);
            this.header.TabIndex = 33;
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
            this.panel4.Size = new System.Drawing.Size(1059, 33);
            this.panel4.TabIndex = 34;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(34, 4);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(161, 20);
            this.label17.TabIndex = 23;
            this.label17.Text = "Filtro de Busqueda";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(418, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(246, 24);
            this.label8.TabIndex = 56;
            this.label8.Text = "Historico libros prestados";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(804, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 20);
            this.label4.TabIndex = 53;
            this.label4.Text = "Generar Reporte";
            // 
            // btnBuscarEstudiantes
            // 
            this.btnBuscarEstudiantes.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarEstudiantes.Image = global::Capas.UI.Properties.Resources.icons8_Increase_80px;
            this.btnBuscarEstudiantes.ImageActive = null;
            this.btnBuscarEstudiantes.Location = new System.Drawing.Point(818, 179);
            this.btnBuscarEstudiantes.Name = "btnBuscarEstudiantes";
            this.btnBuscarEstudiantes.Size = new System.Drawing.Size(107, 70);
            this.btnBuscarEstudiantes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBuscarEstudiantes.TabIndex = 55;
            this.btnBuscarEstudiantes.TabStop = false;
            this.btnBuscarEstudiantes.Zoom = 10;
            this.btnBuscarEstudiantes.Click += new System.EventHandler(this.btnBuscarEstudiantes_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTitulo);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtCodigo);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(476, 142);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(261, 158);
            this.groupBox2.TabIndex = 54;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Libro";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(95, 49);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(126, 22);
            this.txtTitulo.TabIndex = 48;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 16);
            this.label6.TabIndex = 45;
            this.label6.Text = "Titulo";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(95, 21);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(126, 22);
            this.txtCodigo.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 16);
            this.label7.TabIndex = 42;
            this.label7.Text = "Codigo ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPrimerApellido);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtSegundoApellido);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNombreEst);
            this.groupBox1.Controls.Add(this.mskCedulaEstudiante);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(106, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 158);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estudiante";
            // 
            // txtPrimerApellido
            // 
            this.txtPrimerApellido.Location = new System.Drawing.Point(131, 85);
            this.txtPrimerApellido.Name = "txtPrimerApellido";
            this.txtPrimerApellido.Size = new System.Drawing.Size(126, 24);
            this.txtPrimerApellido.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 18);
            this.label5.TabIndex = 47;
            this.label5.Text = "Segundo Apellido";
            // 
            // txtSegundoApellido
            // 
            this.txtSegundoApellido.Location = new System.Drawing.Point(131, 114);
            this.txtSegundoApellido.Name = "txtSegundoApellido";
            this.txtSegundoApellido.Size = new System.Drawing.Size(126, 24);
            this.txtSegundoApellido.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 18);
            this.label1.TabIndex = 45;
            this.label1.Text = "Primer apellido";
            // 
            // txtNombreEst
            // 
            this.txtNombreEst.Location = new System.Drawing.Point(131, 57);
            this.txtNombreEst.Name = "txtNombreEst";
            this.txtNombreEst.Size = new System.Drawing.Size(126, 24);
            this.txtNombreEst.TabIndex = 44;
            // 
            // mskCedulaEstudiante
            // 
            this.mskCedulaEstudiante.Location = new System.Drawing.Point(131, 32);
            this.mskCedulaEstudiante.Mask = "9-9999-9999";
            this.mskCedulaEstudiante.Name = "mskCedulaEstudiante";
            this.mskCedulaEstudiante.Size = new System.Drawing.Size(100, 24);
            this.mskCedulaEstudiante.TabIndex = 43;
            this.mskCedulaEstudiante.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 42;
            this.label3.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 18);
            this.label2.TabIndex = 41;
            this.label2.Text = "Cedula ";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(0, 734);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1051, 32);
            this.panel1.TabIndex = 58;
            // 
            // reportViewerHistorico
            // 
            reportDataSource1.Name = "DsHistoricoLibros";
            reportDataSource1.Value = this.PA_ReporteLibrosPrestadosHistoricoBindingSource;
            this.reportViewerHistorico.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerHistorico.LocalReport.ReportEmbeddedResource = "Capas.UI.reporte.ReportHistoricoLibros.rdlc";
            this.reportViewerHistorico.Location = new System.Drawing.Point(0, 316);
            this.reportViewerHistorico.Name = "reportViewerHistorico";
            this.reportViewerHistorico.Size = new System.Drawing.Size(1051, 422);
            this.reportViewerHistorico.TabIndex = 59;
            // 
            // pAReporteLibrosPrestadosHistoricoBindingSource
            // 
            this.pAReporteLibrosPrestadosHistoricoBindingSource.DataMember = "PA_ReporteLibrosPrestadosHistorico";
            this.pAReporteLibrosPrestadosHistoricoBindingSource.DataSource = this.dBLibrosHistoricoLibrosBindingSource;
            // 
            // dBLibrosHistoricoLibrosBindingSource
            // 
            this.dBLibrosHistoricoLibrosBindingSource.DataSource = this.dBLibrosHistoricoLibros;
            this.dBLibrosHistoricoLibrosBindingSource.Position = 0;
            // 
            // pA_ReporteLibrosPrestadosHistoricoTableAdapter
            // 
            this.pA_ReporteLibrosPrestadosHistoricoTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReporteLibrosPrestados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1059, 768);
            this.Controls.Add(this.reportViewerHistorico);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBuscarEstudiantes);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmReporteLibrosPrestados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmReporteLibrosPrestados";
            this.Load += new System.EventHandler(this.FrmReporteLibrosPrestados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PA_ReporteLibrosPrestadosHistoricoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBLibrosHistoricoLibros)).EndInit();
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarEstudiantes)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pAReporteLibrosPrestadosHistoricoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBLibrosHistoricoLibrosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel header;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuImageButton btnBuscarEstudiantes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPrimerApellido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSegundoApellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreEst;
        private System.Windows.Forms.MaskedTextBox mskCedulaEstudiante;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerHistorico;
        private System.Windows.Forms.BindingSource PA_ReporteLibrosPrestadosHistoricoBindingSource;
        private DBLibrosHistoricoLibros dBLibrosHistoricoLibros;
        private System.Windows.Forms.BindingSource dBLibrosHistoricoLibrosBindingSource;
        private System.Windows.Forms.BindingSource pAReporteLibrosPrestadosHistoricoBindingSource;
        private DBLibrosHistoricoLibrosTableAdapters.PA_ReporteLibrosPrestadosHistoricoTableAdapter pA_ReporteLibrosPrestadosHistoricoTableAdapter;
    }
}