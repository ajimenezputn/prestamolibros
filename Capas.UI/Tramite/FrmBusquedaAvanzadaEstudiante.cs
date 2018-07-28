using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capas.Logica.usuario;
using Capas.Entidades.usuario;

namespace Capas.UI.Tramite
{
    public partial class FrmBusquedaAvanzadaEstudiante : Form
    { 

        public Usuario miUsuario { set; get; }
        public FrmBusquedaAvanzadaEstudiante()
        {
            InitializeComponent();
           
        }

        private void FrmBusquedaAvanzadaEstudiante_Load(object sender, EventArgs e)
        {
            llenarCombos();

            string cedula = "";
            if (mskCedulaEstudiante.MaskFull)
            {
                cedula = mskCedulaEstudiante.Text;
            }
            string seccion = (String)cmbSeccion.SelectedValue;
            if (((Seccion)cmbSeccion.SelectedItem).Id.Equals("Todos"))
            {
                seccion = "";
            }

            refrescar(cedula, txtNombreEst.Text, txtPrimerApellido.Text, txtSegundoApellido.Text, (int)cmbCentro.SelectedValue, seccion);
        }

        private void llenarCombos()
        {

            cmbCentro.DataSource = new CentroEducativoLogica().seleccionarTodosCentrosConComodin();
            cmbCentro.ValueMember = "codigo";
            cmbCentro.DisplayMember = "Nombre";
        }

        private void refrescar(string id, string nombre, string primerApellido, string segundoApellido, int centro, string seccion)
        {
            dataGridUsuarios.Rows.Clear();
            foreach (var item in new UsuarioLogica().listaEstudiantesConFiltro(id, nombre, primerApellido, segundoApellido, centro, seccion))
            {
                string[] row = new string[10];
                row[0] = item.Cedula;
                row[1] = item.Nombre;
                row[2] = item.primerApellido;
                row[3] = item.SegundoApellido;
                row[4] = item.NumeroTelefono;
                row[5] = item.CorreoElectronico;
                row[6] = item.Genero.ToString();
                row[7] = item.FechaNacimiento.ToString();

                row[8] = ((Estudiante)item).CentroEducativo.Nombre;
                row[9] = ((Estudiante)item).Seccion.Id;






                dataGridUsuarios.Rows.Add(row);

            }
        }

        private void btnBuscarEstudiantes_Click(object sender, EventArgs e)
        {
            string cedula = "";
            if (mskCedulaEstudiante.MaskFull)
            {
                cedula = mskCedulaEstudiante.Text;
            }
            string seccion = ((Seccion)cmbSeccion.SelectedItem).Id;
            if (((Seccion)cmbSeccion.SelectedItem).Id.Equals("Todos"))
            {
                seccion = "";
            }

            refrescar(cedula, txtNombreEst.Text, txtPrimerApellido.Text, txtSegundoApellido.Text, (int)cmbCentro.SelectedValue, seccion);
        }

        private void btnSeleccionarEstudiante_Click(object sender, EventArgs e)
        {
            if (dataGridUsuarios.SelectedRows.Count>0)
            {  

                FrmTramite.Estudiante= new UsuarioLogica().selecionarusuario(dataGridUsuarios.SelectedRows[0].Cells[0].Value.ToString());
                this.DialogResult = DialogResult.OK;

            }
        }

        private void cmbCentro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((CentroEducativo)cmbCentro.SelectedItem).Codigo > -1)
            {
                Seccion sec = new Seccion();
                sec.Id = "Todos";
                List<Seccion> milista = ((CentroEducativo)cmbCentro.SelectedItem).listaSeciones;
                milista.RemoveAll(s => s.Id == "Todos");
                milista.Insert(0, sec);
                cmbSeccion.DataSource = null;
                cmbSeccion.DataSource = milista;
                cmbSeccion.DisplayMember = "Id";



            }
            else
            {
                cmbSeccion.DataSource = null;
                cmbSeccion.Items.Clear();
                Seccion sec = new Seccion();
                sec.Id = "Todos";
                cmbSeccion.Items.Add(sec);
                cmbSeccion.DisplayMember = "id";
                cmbSeccion.SelectedIndex = 0;
            }
        }

        private void dataGridUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
