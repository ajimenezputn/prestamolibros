using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capas.Entidades.libro;
using Capas.Logica.libro;

namespace Capas.UI.Tramite
{
    public partial class FrmBusquedaAvanzadaLibro : Form
    {
        public FrmBusquedaAvanzadaLibro()
        {
            InitializeComponent();
        }

        private void FrmBusquedaAvanzadaLibro_Load(object sender, EventArgs e)
        {
            llenarCombos();
            refrescar(txtCodigoLibro.Text, txtTitulo.Text, (int)cmbEditorial.SelectedValue, (int)cmbAutor.SelectedValue);
        }

        private void llenarCombos()
        {
            cmbAutor.DataSource = new AutorLogica().todosLosAutoresComodin();
            cmbEditorial.DataSource = new EditorialLogica().todosLasEditorialesFiltro();
            cmbAutor.ValueMember = "Codigo";
            cmbAutor.DisplayMember = "Nombre";

            cmbEditorial.ValueMember = "Codigo";
            cmbEditorial.DisplayMember = "Nombre";

        }

        private void refrescar(string id, string titulo, int editorial, int autor)
        {
            dataGridLibro.DataSource = new Logica.libro.LibroLogica().seleccionarTodosLibrosFiltro(id, titulo, editorial, autor);
        }

        private void btnBuscarEstudiantes_Click(object sender, EventArgs e)
        {
            refrescar(txtCodigoLibro.Text, txtTitulo.Text, (int)cmbEditorial.SelectedValue, (int)cmbAutor.SelectedValue);
        }

        private void btnSeleccionarEstudiante_Click(object sender, EventArgs e)
        {
            if (dataGridLibro.SelectedRows.Count > 0)
            {

                FrmTramite.Libro = (Libro)dataGridLibro.SelectedRows[0].DataBoundItem;
                this.DialogResult = DialogResult.OK;

            }
        }
    }
}
