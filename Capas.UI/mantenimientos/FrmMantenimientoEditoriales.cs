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
    public partial class FrmMantenimientoEditoriales : Form
    {
        public FrmMantenimientoEditoriales()
        {
            InitializeComponent();
        }

     

        private void FrmMantenimientoEditoriales_Load(object sender, EventArgs e)
        {
            refrescar();
        }
        private void refrescar()
        {
            dataGridEditorial.DataSource = null;
            dataGridEditorial.DataSource = new EditorialLogica().todosLasEditoriales();
        }

        private void habilitar()
        {
            txtNombreEditorial.ReadOnly = false;
        }
        private void deshabilitar()
        {
            txtNombreEditorial.ReadOnly = true;
        }



        private void dataGridEditorial_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridEditorial.SelectedRows.Count > 0)
            {
               Editorial miEditorial = (Editorial)dataGridEditorial.SelectedRows[0].DataBoundItem;
                txtID.Text = miEditorial.Codigo.ToString();
                txtNombreEditorial.Text = miEditorial.Nombre;
            }
            deshabilitar();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevos_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtNombreEditorial.Clear();
            habilitar();
        }

        private void btnGuardarEditorial_Click(object sender, EventArgs e)
        {
            Editorial editorial = new Editorial();
            editorial.Nombre = txtNombreEditorial.Text;
            if (!string.IsNullOrEmpty(txtID.Text))
            {
                editorial.Codigo = Convert.ToInt32(txtID.Text);
            }


            try
            {
                new EditorialLogica().insertarEditorial(editorial);
                MessageBox.Show(null, "Guardado Correctamente", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception a)
            {

                Logica.LogHelper.WriteDebugLog("error guardando la editorial " + a.Message);
                MessageBox.Show(null, "Error al guardar " + a, "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            refrescar();
        }

        private void btnEliminarEditorial_Click(object sender, EventArgs e)
        {
            if (dataGridEditorial.SelectedRows.Count > 0)
            {
                if (MessageBox.Show(null, "Desea eliminar la editorial?", "Atencion!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        new EditorialLogica().eliminarEditorial((Editorial)dataGridEditorial.SelectedRows[0].DataBoundItem);
                        MessageBox.Show(null, "se elimino correctamente!", "Atencion!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception a)
                    {
                        Logica.LogHelper.WriteDebugLog("error eliminado editorial " + a.Message);
                        MessageBox.Show(null, "Error al eliminar  " + a, "Atencion!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
            else
            {
                MessageBox.Show(null, "Selecciona la editorial a eliminar ", "Atencion!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            refrescar();
        }

        private void dataGridEditorial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
    }
}
