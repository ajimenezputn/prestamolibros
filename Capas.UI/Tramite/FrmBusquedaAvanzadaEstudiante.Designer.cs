namespace Capas.UI.Tramite
{
    partial class FrmBusquedaAvanzadaEstudiante
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbCentro = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbSeccion = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBuscarEstudiantes = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtPrimerApellido = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSegundoApellido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreEst = new System.Windows.Forms.TextBox();
            this.mskCedulaEstudiante = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridUsuarios = new System.Windows.Forms.DataGridView();
            this.colCedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrimerApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSegundoApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCorreoElectronico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGenero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCentroEducativo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSeccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSeleccionarEstudiante = new Bunifu.Framework.UI.BunifuImageButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarEstudiantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSeleccionarEstudiante)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbCentro);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cmbSeccion);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnBuscarEstudiantes);
            this.groupBox1.Controls.Add(this.txtPrimerApellido);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtSegundoApellido);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNombreEst);
            this.groupBox1.Controls.Add(this.mskCedulaEstudiante);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(781, 158);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estudiante";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cmbCentro
            // 
            this.cmbCentro.FormattingEnabled = true;
            this.cmbCentro.Location = new System.Drawing.Point(457, 28);
            this.cmbCentro.Name = "cmbCentro";
            this.cmbCentro.Size = new System.Drawing.Size(185, 26);
            this.cmbCentro.TabIndex = 52;
            this.cmbCentro.SelectedIndexChanged += new System.EventHandler(this.cmbCentro_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(329, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 18);
            this.label7.TabIndex = 51;
            this.label7.Text = "Centro Educativo";
            // 
            // cmbSeccion
            // 
            this.cmbSeccion.FormattingEnabled = true;
            this.cmbSeccion.Location = new System.Drawing.Point(457, 63);
            this.cmbSeccion.Name = "cmbSeccion";
            this.cmbSeccion.Size = new System.Drawing.Size(121, 26);
            this.cmbSeccion.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(664, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 54;
            this.label4.Text = "Filtrar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(389, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 18);
            this.label6.TabIndex = 49;
            this.label6.Text = "Seccion";
            // 
            // btnBuscarEstudiantes
            // 
            this.btnBuscarEstudiantes.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarEstudiantes.Image = global::Capas.UI.Properties.Resources.icons8_Search_96px;
            this.btnBuscarEstudiantes.ImageActive = null;
            this.btnBuscarEstudiantes.Location = new System.Drawing.Point(630, 60);
            this.btnBuscarEstudiantes.Name = "btnBuscarEstudiantes";
            this.btnBuscarEstudiantes.Size = new System.Drawing.Size(107, 43);
            this.btnBuscarEstudiantes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBuscarEstudiantes.TabIndex = 56;
            this.btnBuscarEstudiantes.TabStop = false;
            this.btnBuscarEstudiantes.Zoom = 10;
            this.btnBuscarEstudiantes.Click += new System.EventHandler(this.btnBuscarEstudiantes_Click);
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(371, 467);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 20);
            this.label8.TabIndex = 57;
            this.label8.Text = "Seleccionar";
            // 
            // dataGridUsuarios
            // 
            this.dataGridUsuarios.AllowUserToAddRows = false;
            this.dataGridUsuarios.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCedula,
            this.colNombre,
            this.colPrimerApellido,
            this.colSegundoApellido,
            this.colTelefono,
            this.colCorreoElectronico,
            this.colGenero,
            this.colFecha,
            this.colCentroEducativo,
            this.colSeccion});
            this.dataGridUsuarios.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridUsuarios.Location = new System.Drawing.Point(12, 196);
            this.dataGridUsuarios.MultiSelect = false;
            this.dataGridUsuarios.Name = "dataGridUsuarios";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridUsuarios.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridUsuarios.Size = new System.Drawing.Size(781, 191);
            this.dataGridUsuarios.TabIndex = 60;
            this.dataGridUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridUsuarios_CellContentClick);
            // 
            // colCedula
            // 
            this.colCedula.HeaderText = "Cedula";
            this.colCedula.Name = "colCedula";
            this.colCedula.ReadOnly = true;
            this.colCedula.Width = 125;
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            // 
            // colPrimerApellido
            // 
            this.colPrimerApellido.HeaderText = "Primer Apellido";
            this.colPrimerApellido.Name = "colPrimerApellido";
            this.colPrimerApellido.ReadOnly = true;
            // 
            // colSegundoApellido
            // 
            this.colSegundoApellido.HeaderText = "Segundo Apellido";
            this.colSegundoApellido.Name = "colSegundoApellido";
            this.colSegundoApellido.ReadOnly = true;
            // 
            // colTelefono
            // 
            this.colTelefono.HeaderText = "Telefono";
            this.colTelefono.Name = "colTelefono";
            this.colTelefono.ReadOnly = true;
            this.colTelefono.Width = 125;
            // 
            // colCorreoElectronico
            // 
            this.colCorreoElectronico.HeaderText = "Correo Electronico";
            this.colCorreoElectronico.Name = "colCorreoElectronico";
            this.colCorreoElectronico.ReadOnly = true;
            this.colCorreoElectronico.Width = 200;
            // 
            // colGenero
            // 
            this.colGenero.HeaderText = "Genero";
            this.colGenero.Name = "colGenero";
            this.colGenero.ReadOnly = true;
            // 
            // colFecha
            // 
            this.colFecha.HeaderText = "Fecha Nacimiento";
            this.colFecha.Name = "colFecha";
            this.colFecha.ReadOnly = true;
            // 
            // colCentroEducativo
            // 
            this.colCentroEducativo.HeaderText = "Centro Educativo";
            this.colCentroEducativo.Name = "colCentroEducativo";
            this.colCentroEducativo.ReadOnly = true;
            this.colCentroEducativo.Width = 200;
            // 
            // colSeccion
            // 
            this.colSeccion.HeaderText = "Sección";
            this.colSeccion.Name = "colSeccion";
            this.colSeccion.ReadOnly = true;
            // 
            // btnSeleccionarEstudiante
            // 
            this.btnSeleccionarEstudiante.BackColor = System.Drawing.Color.Transparent;
            this.btnSeleccionarEstudiante.Image = global::Capas.UI.Properties.Resources.icons8_Checked_Checkbox_48px;
            this.btnSeleccionarEstudiante.ImageActive = null;
            this.btnSeleccionarEstudiante.Location = new System.Drawing.Point(379, 393);
            this.btnSeleccionarEstudiante.Name = "btnSeleccionarEstudiante";
            this.btnSeleccionarEstudiante.Size = new System.Drawing.Size(71, 71);
            this.btnSeleccionarEstudiante.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSeleccionarEstudiante.TabIndex = 56;
            this.btnSeleccionarEstudiante.TabStop = false;
            this.btnSeleccionarEstudiante.Zoom = 10;
            this.btnSeleccionarEstudiante.Click += new System.EventHandler(this.btnSeleccionarEstudiante_Click);
            // 
            // FrmBusquedaAvanzadaEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(814, 502);
            this.Controls.Add(this.dataGridUsuarios);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnSeleccionarEstudiante);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmBusquedaAvanzadaEstudiante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busqueda Avanzada Estudiante";
            this.Load += new System.EventHandler(this.FrmBusquedaAvanzadaEstudiante_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarEstudiantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSeleccionarEstudiante)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbCentro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbSeccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuImageButton btnBuscarEstudiantes;
        private System.Windows.Forms.TextBox txtPrimerApellido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSegundoApellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreEst;
        private System.Windows.Forms.MaskedTextBox mskCedulaEstudiante;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuImageButton btnSeleccionarEstudiante;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrimerApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSegundoApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCorreoElectronico;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGenero;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCentroEducativo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSeccion;
    }
}