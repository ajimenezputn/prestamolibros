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
using Capas.Logica.libro;
using Capas.Entidades.usuario;
using Capas.Logica.facade;

namespace Capas.UI.reporte
{
    public partial class FrmReporteQr : Form
    {
        public FrmReporteQr()
        {
            InitializeComponent();
        }

        private void FrmReporteQr_Load(object sender, EventArgs e)
        {
            llenarCombos();

            string cedula="";
            if (mskCedulaEstudiante.MaskFull)
            {
                cedula = mskCedulaEstudiante.Text;
            }
            string seccion = (String)cmbSeccion.SelectedValue;
            if (((Seccion)cmbSeccion.SelectedItem).Id.Equals("Todos"))
            {
                seccion = "";
            }

            refrescar(cedula,txtNombreEst.Text,txtPrimerApellido.Text,txtSegundoApellido.Text,(int)cmbCentro.SelectedValue,seccion);
        }

        private void llenarCombos()
        {

            cmbCentro.DataSource = new CentroEducativoLogica().seleccionarTodosCentrosConComodin();
            cmbCentro.ValueMember = "codigo";
            cmbCentro.DisplayMember = "Nombre";
        }

        private void refrescar(string id,string nombre,string primerApellido,string segundoApellido,int centro,string seccion)
        {
            dataGridUsuarios.Rows.Clear();
            foreach (var item in new UsuarioLogica().listaEstudiantesConFiltro(id,nombre,primerApellido,segundoApellido,centro, seccion))
            {
                string[] row = new string[11];
                row[1] = item.Cedula;
                row[2] = item.Nombre;
                row[3] = item.primerApellido;
                row[4] = item.SegundoApellido;
                row[5] = item.NumeroTelefono;
                row[6] = item.CorreoElectronico;
                row[7] = item.Genero.ToString();
                row[8] = item.FechaNacimiento.ToString();

                row[9] = ((Estudiante)item).CentroEducativo.Nombre;
                row[10] = ((Estudiante)item).Seccion.Id;






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

        private void cmbCentro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((CentroEducativo)cmbCentro.SelectedItem).Codigo>-1)
            {   
                Seccion sec = new Seccion();
                sec.Id = "Todos";
                List<Seccion> milista = ((CentroEducativo)cmbCentro.SelectedItem).listaSeciones;
                milista.RemoveAll(s=>s.Id=="Todos");
                milista.Insert(0,sec);
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

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkMarcarTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMarcarTodos.Checked)
            {

                foreach (DataGridViewRow item in dataGridUsuarios.Rows)
                {
                    item.Cells[0].Value = true;
                }
            }
            else
            {
                foreach (DataGridViewRow item in dataGridUsuarios.Rows)
                {
                    item.Cells[0].Value = false;
                }
            }
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            int contSeleccionados = 0;
             List<Estudiante> lista = new List<Estudiante>();

            foreach (DataGridViewRow item in dataGridUsuarios.Rows)
            {
             
                if (Convert.ToBoolean(item.Cells[0].Value))
                {
                    Estudiante estudiante = (Estudiante)new UsuarioLogica().selecionarusuario(item.Cells[1].Value.ToString());
                    lista.Add(estudiante);
                    contSeleccionados++;
                }
            }

            if (contSeleccionados<1)
            {
                MessageBox.Show(null, "Antes de generar el reporte! seleccione los estudiantes", "atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
    
       
            FrmVerQR frm = new FrmVerQR();
            frm.miLista = new TramitarFacade().reporteQrEstudiantes(lista);
            frm.ShowDialog();
        }

        private void dataGridUsuarios_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridUsuarios.IsCurrentCellDirty)
            {
                dataGridUsuarios.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
