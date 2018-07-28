namespace Capas.UI.Tramite
{
    partial class FrmConfiguracion
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
            this.txtRepitaContrasena = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.groupBoxEmail = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxPrestamo = new System.Windows.Forms.GroupBox();
            this.numUpCantidadLibros = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.btnModificarEmail = new System.Windows.Forms.Button();
            this.btnModificarPrestamo = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBoxEmail.SuspendLayout();
            this.groupBoxPrestamo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpCantidadLibros)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRepitaContrasena
            // 
            this.txtRepitaContrasena.Location = new System.Drawing.Point(134, 163);
            this.txtRepitaContrasena.Name = "txtRepitaContrasena";
            this.txtRepitaContrasena.Size = new System.Drawing.Size(117, 20);
            this.txtRepitaContrasena.TabIndex = 0;
            this.txtRepitaContrasena.UseSystemPasswordChar = true;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(134, 89);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(169, 20);
            this.txtEmail.TabIndex = 1;
            // 
            // txtContrasena
            // 
            this.txtContrasena.Location = new System.Drawing.Point(134, 137);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(117, 20);
            this.txtContrasena.TabIndex = 2;
            this.txtContrasena.UseSystemPasswordChar = true;
            // 
            // groupBoxEmail
            // 
            this.groupBoxEmail.Controls.Add(this.label5);
            this.groupBoxEmail.Controls.Add(this.label3);
            this.groupBoxEmail.Controls.Add(this.label2);
            this.groupBoxEmail.Controls.Add(this.label1);
            this.groupBoxEmail.Controls.Add(this.txtEmail);
            this.groupBoxEmail.Controls.Add(this.txtContrasena);
            this.groupBoxEmail.Controls.Add(this.txtRepitaContrasena);
            this.groupBoxEmail.Location = new System.Drawing.Point(12, 188);
            this.groupBoxEmail.Name = "groupBoxEmail";
            this.groupBoxEmail.Size = new System.Drawing.Size(419, 220);
            this.groupBoxEmail.TabIndex = 3;
            this.groupBoxEmail.TabStop = false;
            this.groupBoxEmail.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(401, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Configure la cuenta de correo que utilizara el sistema para notificar a los estud" +
    "iantes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "repita la contraseña";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Direccion de email";
            // 
            // groupBoxPrestamo
            // 
            this.groupBoxPrestamo.Controls.Add(this.numUpCantidadLibros);
            this.groupBoxPrestamo.Controls.Add(this.label4);
            this.groupBoxPrestamo.Location = new System.Drawing.Point(12, 43);
            this.groupBoxPrestamo.Name = "groupBoxPrestamo";
            this.groupBoxPrestamo.Size = new System.Drawing.Size(419, 100);
            this.groupBoxPrestamo.TabIndex = 4;
            this.groupBoxPrestamo.TabStop = false;
            this.groupBoxPrestamo.Text = "Prestamo";
            // 
            // numUpCantidadLibros
            // 
            this.numUpCantidadLibros.Location = new System.Drawing.Point(327, 37);
            this.numUpCantidadLibros.Name = "numUpCantidadLibros";
            this.numUpCantidadLibros.Size = new System.Drawing.Size(75, 20);
            this.numUpCantidadLibros.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(295, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cantidad maxima de libros que se le prestan a los estudiantes";
            // 
            // btnModificarEmail
            // 
            this.btnModificarEmail.Location = new System.Drawing.Point(12, 159);
            this.btnModificarEmail.Name = "btnModificarEmail";
            this.btnModificarEmail.Size = new System.Drawing.Size(75, 23);
            this.btnModificarEmail.TabIndex = 5;
            this.btnModificarEmail.Text = "Modificar";
            this.btnModificarEmail.UseVisualStyleBackColor = true;
            this.btnModificarEmail.Click += new System.EventHandler(this.btnModificarEmail_Click);
            // 
            // btnModificarPrestamo
            // 
            this.btnModificarPrestamo.Location = new System.Drawing.Point(12, 12);
            this.btnModificarPrestamo.Name = "btnModificarPrestamo";
            this.btnModificarPrestamo.Size = new System.Drawing.Size(75, 23);
            this.btnModificarPrestamo.TabIndex = 6;
            this.btnModificarPrestamo.Text = "Modificar";
            this.btnModificarPrestamo.UseVisualStyleBackColor = true;
            this.btnModificarPrestamo.Click += new System.EventHandler(this.btnModificarPrestamo_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(176, 421);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Guardar Cambios";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FrmConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(451, 456);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnModificarPrestamo);
            this.Controls.Add(this.btnModificarEmail);
            this.Controls.Add(this.groupBoxPrestamo);
            this.Controls.Add(this.groupBoxEmail);
            this.Name = "FrmConfiguracion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmConfiguracion";
            this.Load += new System.EventHandler(this.FrmConfiguracion_Load);
            this.groupBoxEmail.ResumeLayout(false);
            this.groupBoxEmail.PerformLayout();
            this.groupBoxPrestamo.ResumeLayout(false);
            this.groupBoxPrestamo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpCantidadLibros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtRepitaContrasena;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.GroupBox groupBoxEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxPrestamo;
        private System.Windows.Forms.NumericUpDown numUpCantidadLibros;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnModificarEmail;
        private System.Windows.Forms.Button btnModificarPrestamo;
        private System.Windows.Forms.Button button3;
    }
}