using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capas.Entidades.usuario;

namespace Capas.UI.Tramite
{
    public partial class FrmDetalleEstudiante : Form
    {
        public Estudiante Estudiante { set; get; }
        public FrmDetalleEstudiante()
        {
            InitializeComponent();
        }

        private void FrmDetalleEstudiante_Load(object sender, EventArgs e)
        {
            mskCedula.Text = Estudiante.Cedula;
            txtNombre.Text =Estudiante.Nombre;
            txtPrimerApellido.Text = Estudiante.primerApellido;
            txtSegundoApellido.Text = Estudiante.SegundoApellido;
            mskTelefono.Text = Estudiante.NumeroTelefono;
            txtCorreo.Text = Estudiante.CorreoElectronico;
            txtGenero.Text = Estudiante.Genero.ToString();
            txtFecha.Text = Estudiante.FechaNacimiento.ToShortDateString();
            txtCentro.Text = Estudiante.CentroEducativo.Nombre;
            txtSeccion.Text = Estudiante.Seccion.Id;
        }
    }
}
