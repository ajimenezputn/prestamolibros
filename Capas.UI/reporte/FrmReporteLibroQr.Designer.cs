namespace Capas.UI.reporte
{
    partial class FrmReporteLibroQr
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label9 = new System.Windows.Forms.Label();
            this.btnGenerarReporte = new Bunifu.Framework.UI.BunifuImageButton();
            this.chkMarcarTodos = new System.Windows.Forms.CheckBox();
            this.dataGridLibros = new System.Windows.Forms.DataGridView();
            this.colReport = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbAutor = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbEditorial = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBuscarEstudiantes = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigoLibro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnGenerarReporte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLibros)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarEstudiantes)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(417, 272);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(211, 24);
            this.label9.TabIndex = 66;
            this.label9.Text = "Generar Reporte de QR";
            // 
            // btnGenerarReporte
            // 
            this.btnGenerarReporte.BackColor = System.Drawing.Color.Transparent;
            this.btnGenerarReporte.Image = global::Capas.UI.Properties.Resources.icons8_Increase_80px;
            this.btnGenerarReporte.ImageActive = null;
            this.btnGenerarReporte.Location = new System.Drawing.Point(451, 204);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Size = new System.Drawing.Size(132, 65);
            this.btnGenerarReporte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnGenerarReporte.TabIndex = 63;
            this.btnGenerarReporte.TabStop = false;
            this.btnGenerarReporte.Zoom = 10;
            this.btnGenerarReporte.Click += new System.EventHandler(this.btnGenerarReporte_Click);
            // 
            // chkMarcarTodos
            // 
            this.chkMarcarTodos.AutoSize = true;
            this.chkMarcarTodos.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.chkMarcarTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMarcarTodos.Location = new System.Drawing.Point(73, 265);
            this.chkMarcarTodos.Name = "chkMarcarTodos";
            this.chkMarcarTodos.Size = new System.Drawing.Size(106, 38);
            this.chkMarcarTodos.TabIndex = 65;
            this.chkMarcarTodos.Text = "Marcar todos";
            this.chkMarcarTodos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkMarcarTodos.UseVisualStyleBackColor = true;
            this.chkMarcarTodos.CheckedChanged += new System.EventHandler(this.chkMarcarTodos_CheckedChanged);
            // 
            // dataGridLibros
            // 
            this.dataGridLibros.AllowUserToAddRows = false;
            this.dataGridLibros.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridLibros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridLibros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colReport});
            this.dataGridLibros.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridLibros.Location = new System.Drawing.Point(38, 309);
            this.dataGridLibros.MultiSelect = false;
            this.dataGridLibros.Name = "dataGridLibros";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridLibros.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridLibros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridLibros.Size = new System.Drawing.Size(959, 307);
            this.dataGridLibros.TabIndex = 64;
            this.dataGridLibros.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridLibros_CurrentCellDirtyStateChanged);
            // 
            // colReport
            // 
            this.colReport.HeaderText = "Reporte";
            this.colReport.Name = "colReport";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbAutor);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cmbEditorial);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnBuscarEstudiantes);
            this.groupBox1.Controls.Add(this.txtTitulo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCodigoLibro);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(125, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(769, 158);
            this.groupBox1.TabIndex = 62;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Libro";
            // 
            // cmbAutor
            // 
            this.cmbAutor.FormattingEnabled = true;
            this.cmbAutor.Location = new System.Drawing.Point(388, 55);
            this.cmbAutor.Name = "cmbAutor";
            this.cmbAutor.Size = new System.Drawing.Size(121, 26);
            this.cmbAutor.TabIndex = 52;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(320, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 18);
            this.label7.TabIndex = 51;
            this.label7.Text = "Autor";
            // 
            // cmbEditorial
            // 
            this.cmbEditorial.FormattingEnabled = true;
            this.cmbEditorial.Location = new System.Drawing.Point(388, 90);
            this.cmbEditorial.Name = "cmbEditorial";
            this.cmbEditorial.Size = new System.Drawing.Size(121, 26);
            this.cmbEditorial.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(627, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 54;
            this.label4.Text = "Filtrar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(320, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 18);
            this.label6.TabIndex = 49;
            this.label6.Text = "Editorial";
            // 
            // btnBuscarEstudiantes
            // 
            this.btnBuscarEstudiantes.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarEstudiantes.Image = global::Capas.UI.Properties.Resources.icons8_Search_96px;
            this.btnBuscarEstudiantes.ImageActive = null;
            this.btnBuscarEstudiantes.Location = new System.Drawing.Point(593, 55);
            this.btnBuscarEstudiantes.Name = "btnBuscarEstudiantes";
            this.btnBuscarEstudiantes.Size = new System.Drawing.Size(107, 43);
            this.btnBuscarEstudiantes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBuscarEstudiantes.TabIndex = 56;
            this.btnBuscarEstudiantes.TabStop = false;
            this.btnBuscarEstudiantes.Zoom = 10;
            this.btnBuscarEstudiantes.Click += new System.EventHandler(this.btnBuscarEstudiantes_Click);
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(131, 98);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(126, 24);
            this.txtTitulo.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 45;
            this.label1.Text = "Titulo";
            // 
            // txtCodigoLibro
            // 
            this.txtCodigoLibro.Location = new System.Drawing.Point(131, 57);
            this.txtCodigoLibro.Name = "txtCodigoLibro";
            this.txtCodigoLibro.Size = new System.Drawing.Size(126, 24);
            this.txtCodigoLibro.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 18);
            this.label3.TabIndex = 42;
            this.label3.Text = "Codigo";
            // 
            // FrmReporteLibroQr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1027, 629);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnGenerarReporte);
            this.Controls.Add(this.chkMarcarTodos);
            this.Controls.Add(this.dataGridLibros);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmReporteLibroQr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmReporteLibroQr";
            this.Load += new System.EventHandler(this.FrmReporteLibroQr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnGenerarReporte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLibros)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarEstudiantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private Bunifu.Framework.UI.BunifuImageButton btnGenerarReporte;
        private System.Windows.Forms.CheckBox chkMarcarTodos;
        private System.Windows.Forms.DataGridView dataGridLibros;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colReport;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbAutor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbEditorial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuImageButton btnBuscarEstudiantes;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigoLibro;
        private System.Windows.Forms.Label label3;
    }
}