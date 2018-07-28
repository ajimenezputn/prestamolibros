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

namespace Capas.UI.mantenimientos
{
    public partial class FrmMantenimientoLibros : Form
    {
        List<Autor> miListaAutores = new List<Autor>();
        public FrmMantenimientoLibros()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void habilitar()
        {

            cmbEditoriales.Enabled = true;
            txtTitulo.ReadOnly = false;
            numFecha.Enabled = true;

        }
        private void deshabilitar()
        {

            cmbEditoriales.Enabled = false;
            txtTitulo.ReadOnly = true;
            numFecha.Enabled = false;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            Libro miLibro = new LibroFactory().crearLibro(txtCodigo.Text, txtTitulo.Text, (int)numFecha.Value, (Editorial)cmbEditoriales.SelectedItem, miListaAutores);

            try
            {
                new LibroLogica().guardar(miLibro);
                MessageBox.Show(null, "Guardado exitosamente!", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                miListaAutores.Clear();
            }
            catch (Exception a)
            {
                Logica.LogHelper.WriteDebugLog("error agregando libro " + a.Message);
                MessageBox.Show(null, "Error al guardar ! " + a, "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            refrescar();
            deshabilitar();
        }

        private void FrmMantenimientoLibros_Load(object sender, EventArgs e)
        {
            refrescar();
            llenarCombos();
            deshabilitar();
        }

        private void llenarCombos()
        {
            cmbEditoriales.DataSource = new EditorialLogica().todosLasEditoriales();
            cmbEditoriales.DisplayMember = "nombre";
            cmbEditoriales.ValueMember = "codigo";
        }

        private void refrescar()
        {
            dataGridLibros.DataSource = null;
            dataGridLibros.DataSource = new LibroLogica().todosLosLibros();
        }

        private void btnAgregarAutor_Click(object sender, EventArgs e)
        {
          
        }

        private void btnEliminarAutores_Click(object sender, EventArgs e)
        {

        }

        private void dataGridLibros_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridLibros.SelectedRows.Count > 0)
            {
                Libro miLibro = (Libro)dataGridLibros.SelectedRows[0].DataBoundItem;
                txtCodigo.Text = miLibro.Codigo.ToString();
                txtTitulo.Text = miLibro.Titulo;
                numFecha.Value = miLibro.fechaPublicacion;

                
                cmbEditoriales.SelectedValue =  miLibro.Editorial.Codigo;
            }
            else
            {
                limpiar();
              
            }
            deshabilitar();
          
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridLibros.SelectedRows.Count > 0)
            {
                if (MessageBox.Show(null, "Desea eliminar el libro?", "Atencion!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        new LibroLogica().eliminarLibro((Libro)dataGridLibros.SelectedRows[0].DataBoundItem);
                        MessageBox.Show(null, "Eliminado Correctamente", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch (Exception a)
                    {
                        Logica.LogHelper.WriteDebugLog("error eliminando autor " + a.Message);
                        MessageBox.Show(null, "Error al eliminar !" + a, "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(null, "Por favor ! Seleccione el libro a eliminar !", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                refrescar();
              
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiar();
            habilitar();
        }

        private void limpiar()
        {
           
            txtCodigo.Clear();
            txtTitulo.Clear();
            numFecha.ResetText();
            numFecha.ResetText();
            dataGridLibros.ClearSelection();
        
        }

    

        private void btnAutores_Click(object sender, EventArgs e)
        {
            if (dataGridLibros.SelectedRows.Count>0)
            {
                try {
                    FrmLibroAutor frm = new FrmLibroAutor();
                    frm.Libro = (Libro)dataGridLibros.SelectedRows[0].DataBoundItem;
                    frm.ShowDialog();
                }
                catch (Exception)
                {

                }
            }
            else
            {
                MessageBox.Show(null, "seleccione un libro antes! para ver sus autores !", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
       
        }

        private void txtTitulo_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTitulo.Text))
            {
                errorProviderTitulo.SetError(txtTitulo,"Por favor !escriba un titulo para el libro");
            }
            else
            {
                errorProviderTitulo.SetError(txtTitulo,"");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            habilitar();
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
