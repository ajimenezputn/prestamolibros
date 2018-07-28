using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capas.Entidades;
using Capas.Logica;

namespace Capas.UI.Tramite
{
    public partial class FrmConfiguracion : Form
    {
        public FrmConfiguracion()
        {
            InitializeComponent();
        }

        private void FrmConfiguracion_Load(object sender, EventArgs e)
        {
            Configuracion miConfig = new Configuracionlogica().seleccionarConfiguracion();
            if (miConfig!=null)
            {
                numUpCantidadLibros.Value = miConfig.cantidadLibros;
                txtEmail.Text = miConfig.email;
                txtContrasena.Text = miConfig.password;
                txtRepitaContrasena.Text = miConfig.password;

            }
            groupBoxEmail.Enabled = false;
            groupBoxPrestamo.Enabled = false;
       
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Configuracion miConfig = new Configuracion();
            miConfig.cantidadLibros = (int)numUpCantidadLibros.Value;
            miConfig.email = txtEmail.Text;

            if(!txtContrasena.Text.Equals(txtRepitaContrasena.Text))
            {
                MessageBox.Show("Las contraseñas no coinciden");
                return;
            }
            else
            {
                miConfig.password = txtRepitaContrasena.Text;
                try
                {
                    new Configuracionlogica().guardarConfiguracion(miConfig);
                    MessageBox.Show(null,"Configuracion guardada correctamente","Atencion!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    groupBoxEmail.Enabled = false;
                    groupBoxPrestamo.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error "+ex.Message);

                }


               
            }
            
        }

        private void btnModificarPrestamo_Click(object sender, EventArgs e)
        {
           
            groupBoxPrestamo.Enabled = true;
        }

        private void btnModificarEmail_Click(object sender, EventArgs e)
        {
            groupBoxEmail.Enabled = true;
           
        }
    }
}
