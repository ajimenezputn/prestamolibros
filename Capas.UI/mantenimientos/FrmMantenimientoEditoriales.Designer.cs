namespace Capas.UI.mantenimientos
{
    partial class FrmMantenimientoEditoriales
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.header = new System.Windows.Forms.Panel();
            this.btnMin = new Bunifu.Framework.UI.BunifuImageButton();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCerrar = new Bunifu.Framework.UI.BunifuImageButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreEditorial = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.dataGridEditorial = new System.Windows.Forms.DataGridView();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.btnEditar = new Bunifu.Framework.UI.BunifuImageButton();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnNuevos = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnEliminarEditorial = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnGuardarEditorial = new Bunifu.Framework.UI.BunifuImageButton();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEditorial)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNuevos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminarEditorial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardarEditorial)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.RoyalBlue;
            this.header.Controls.Add(this.btnMin);
            this.header.Controls.Add(this.label3);
            this.header.Controls.Add(this.btnCerrar);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(680, 49);
            this.header.TabIndex = 0;
            // 
            // btnMin
            // 
            this.btnMin.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnMin.Image = global::Capas.UI.Properties.Resources.icons8_Minimize_Window_96px;
            this.btnMin.ImageActive = null;
            this.btnMin.Location = new System.Drawing.Point(556, 1);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(55, 48);
            this.btnMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMin.TabIndex = 27;
            this.btnMin.TabStop = false;
            this.btnMin.Zoom = 10;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(21, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mantenimiento de Editoriales";
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCerrar.Image = global::Capas.UI.Properties.Resources.icons8_Close_Window_96px;
            this.btnCerrar.ImageActive = null;
            this.btnCerrar.Location = new System.Drawing.Point(612, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(68, 49);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Zoom = 10;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(95, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nombre Editorial";
            // 
            // txtNombreEditorial
            // 
            this.txtNombreEditorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreEditorial.Location = new System.Drawing.Point(227, 46);
            this.txtNombreEditorial.Name = "txtNombreEditorial";
            this.txtNombreEditorial.Size = new System.Drawing.Size(264, 26);
            this.txtNombreEditorial.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Codigo";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(227, 7);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(114, 26);
            this.txtID.TabIndex = 10;
            // 
            // dataGridEditorial
            // 
            this.dataGridEditorial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridEditorial.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridEditorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridEditorial.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridEditorial.Location = new System.Drawing.Point(70, 219);
            this.dataGridEditorial.Name = "dataGridEditorial";
            this.dataGridEditorial.ReadOnly = true;
            this.dataGridEditorial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridEditorial.Size = new System.Drawing.Size(509, 172);
            this.dataGridEditorial.TabIndex = 9;
            this.dataGridEditorial.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridEditorial_CellContentClick);
            this.dataGridEditorial.SelectionChanged += new System.EventHandler(this.dataGridEditorial_SelectionChanged);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.header;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.dataGridEditorial);
            this.panel1.Controls.Add(this.btnEditar);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.btnNuevos);
            this.panel1.Controls.Add(this.btnEliminarEditorial);
            this.panel1.Controls.Add(this.btnGuardarEditorial);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtNombreEditorial);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Location = new System.Drawing.Point(12, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(656, 437);
            this.panel1.TabIndex = 17;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(539, 71);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(51, 20);
            this.label18.TabIndex = 63;
            this.label18.Text = "Editar";
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.White;
            this.btnEditar.Image = global::Capas.UI.Properties.Resources.icons8_Edit_Property_80px;
            this.btnEditar.ImageActive = null;
            this.btnEditar.Location = new System.Drawing.Point(520, 7);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(99, 51);
            this.btnEditar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEditar.TabIndex = 64;
            this.btnEditar.TabStop = false;
            this.btnEditar.Zoom = 10;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(408, 178);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 20);
            this.label12.TabIndex = 60;
            this.label12.Text = "Eliminar";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(303, 178);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 20);
            this.label11.TabIndex = 59;
            this.label11.Text = "Guardar";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(204, 178);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 20);
            this.label10.TabIndex = 58;
            this.label10.Text = "Nuevo";
            // 
            // btnNuevos
            // 
            this.btnNuevos.BackColor = System.Drawing.Color.White;
            this.btnNuevos.Image = global::Capas.UI.Properties.Resources.icons8_New_Copy_80px;
            this.btnNuevos.ImageActive = null;
            this.btnNuevos.Location = new System.Drawing.Point(185, 113);
            this.btnNuevos.Name = "btnNuevos";
            this.btnNuevos.Size = new System.Drawing.Size(90, 55);
            this.btnNuevos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnNuevos.TabIndex = 57;
            this.btnNuevos.TabStop = false;
            this.btnNuevos.Zoom = 10;
            this.btnNuevos.Click += new System.EventHandler(this.btnNuevos_Click);
            // 
            // btnEliminarEditorial
            // 
            this.btnEliminarEditorial.BackColor = System.Drawing.Color.White;
            this.btnEliminarEditorial.Image = global::Capas.UI.Properties.Resources.icons8_Trash_Can_100px;
            this.btnEliminarEditorial.ImageActive = null;
            this.btnEliminarEditorial.Location = new System.Drawing.Point(399, 113);
            this.btnEliminarEditorial.Name = "btnEliminarEditorial";
            this.btnEliminarEditorial.Size = new System.Drawing.Size(74, 55);
            this.btnEliminarEditorial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEliminarEditorial.TabIndex = 56;
            this.btnEliminarEditorial.TabStop = false;
            this.btnEliminarEditorial.Zoom = 10;
            this.btnEliminarEditorial.Click += new System.EventHandler(this.btnEliminarEditorial_Click);
            // 
            // btnGuardarEditorial
            // 
            this.btnGuardarEditorial.BackColor = System.Drawing.Color.White;
            this.btnGuardarEditorial.Image = global::Capas.UI.Properties.Resources.icons8_Save_96px;
            this.btnGuardarEditorial.ImageActive = null;
            this.btnGuardarEditorial.Location = new System.Drawing.Point(299, 113);
            this.btnGuardarEditorial.Name = "btnGuardarEditorial";
            this.btnGuardarEditorial.Size = new System.Drawing.Size(82, 55);
            this.btnGuardarEditorial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnGuardarEditorial.TabIndex = 55;
            this.btnGuardarEditorial.TabStop = false;
            this.btnGuardarEditorial.Zoom = 10;
            this.btnGuardarEditorial.Click += new System.EventHandler(this.btnGuardarEditorial_Click);
            // 
            // FrmMantenimientoEditoriales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(680, 504);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMantenimientoEditoriales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMantenimientoEditoriales";
            this.Load += new System.EventHandler(this.FrmMantenimientoEditoriales_Load);
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEditorial)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNuevos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminarEditorial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardarEditorial)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreEditorial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.DataGridView dataGridEditorial;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuImageButton btnCerrar;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private Bunifu.Framework.UI.BunifuImageButton btnNuevos;
        private Bunifu.Framework.UI.BunifuImageButton btnEliminarEditorial;
        private Bunifu.Framework.UI.BunifuImageButton btnGuardarEditorial;
        private System.Windows.Forms.Label label18;
        private Bunifu.Framework.UI.BunifuImageButton btnEditar;
        private Bunifu.Framework.UI.BunifuImageButton btnMin;
    }
}