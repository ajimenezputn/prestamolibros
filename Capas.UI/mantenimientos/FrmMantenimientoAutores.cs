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
    public partial class FrmMantenimientoAutores : Form
    {
        public FrmMantenimientoAutores()
        {
            InitializeComponent();
        }

        private void habilitar()
        {
            txtNombreAutor.ReadOnly = false;
        }
        private void deshabilitar()
        {
            txtNombreAutor.ReadOnly = true;
        }

        private void FrmMantenimientoAutores_Load(object sender, EventArgs e)
        {
            refrescar();
            deshabilitar();
        }

        private void refrescar()
        {
            dataGridAutores.DataSource = null;
            dataGridAutores.DataSource = new AutorLogica().todosLosAutores();
        }

    

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridAutores_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridAutores.SelectedRows.Count>0)
            {
                Autor miAutor = (Autor)dataGridAutores.SelectedRows[0].DataBoundItem;
                txtID.Text = miAutor.Codigo.ToString();
                txtNombreAutor.Text = miAutor.Nombre;
            }
            deshabilitar();


        }

     
  

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtNombreAutor_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridAutores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNuevos_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtNombreAutor.Clear();
            habilitar();
        }

        private void btnGuardarAutor_Click(object sender, EventArgs e)
        {
            Autor miAutor = new Autor();
            miAutor.Nombre = txtNombreAutor.Text;
            if (!string.IsNullOrEmpty(txtID.Text))
            {
                miAutor.Codigo = Convert.ToInt32(txtID.Text);
            }


            try
            {
                new AutorLogica().insertarAutor(miAutor);
                MessageBox.Show(null, "Guardado Correctamente", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception a)
            {

                Logica.LogHelper.WriteDebugLog("error al guardar autor " + a);
                MessageBox.Show(null, "Error al guardar " + a, "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            refrescar();
        }

        private void btnEliminarAutor_Click(object sender, EventArgs e)
        {
            if (dataGridAutores.SelectedRows.Count > 0)
            {
                if (MessageBox.Show(null, "Desea eliminar el autor?", "Atencion!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        new AutorLogica().eliminarAutor((Autor)dataGridAutores.SelectedRows[0].DataBoundItem);
                        MessageBox.Show(null, "se elimino correctamente!", "Atencion!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception a)
                    {
                        Logica.LogHelper.WriteDebugLog("error eliminado autor " + a);
                        MessageBox.Show(null, "Error al eliminar  " + a, "Atencion!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
            else
            {
                MessageBox.Show(null, "Selecciona el autor a eliminar ", "Atencion!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            refrescar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            habilitar();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void header_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
