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
using Capas.Logica.facade;

namespace Capas.UI.reporte
{
    public partial class FrmReporteLibroQr : Form
    {
        public FrmReporteLibroQr()
        {
            InitializeComponent();
        }

        private void FrmReporteLibroQr_Load(object sender, EventArgs e)
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
            dataGridLibros.DataSource = new Logica.libro.LibroLogica().seleccionarTodosLibrosFiltro(id, titulo, editorial, autor);
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            int contSeleccionados = 0;
            List<Libro> lista = new List<Libro>();

            foreach (DataGridViewRow item in dataGridLibros.Rows)
            {

                if (Convert.ToBoolean(item.Cells[0].Value))
                {
                    Libro miLibro = (Libro)item.DataBoundItem;
                    lista.Add(miLibro);
                    contSeleccionados++;
                }
            }

            if (contSeleccionados < 1)
            {
                MessageBox.Show(null, "Antes de generar el reporte! seleccione los estudiantes", "atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                FrmVerQrLibro frm = new FrmVerQrLibro();
                frm.miLista = new TramitarFacade().reporteQrLibros(lista);
                frm.ShowDialog();


            }
        }

        private void btnBuscarEstudiantes_Click(object sender, EventArgs e)
        {
            refrescar(txtCodigoLibro.Text, txtTitulo.Text, (int)cmbEditorial.SelectedValue, (int)cmbAutor.SelectedValue);
        }

        private void dataGridLibros_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridLibros.IsCurrentCellDirty)
            {
                dataGridLibros.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void chkMarcarTodos_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (chkMarcarTodos.Checked)
                {

                    foreach (DataGridViewRow item in dataGridLibros.Rows)
                    {
                        item.Cells[0].Value = true;
                    }
                }
                else
                {
                    foreach (DataGridViewRow item in dataGridLibros.Rows)
                    {
                        item.Cells[0].Value = false;
                    }
                }
            }
        }
    }
}
