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
using Capas.Logica.usuario;



namespace slnLibros.mantenimientos
{
    public partial class FrmMantenimientosCentroYsecciones : Form
    {
        CentroEducativoLogica centroLogica = new CentroEducativoLogica();
        CentroEducativo centro;
        public FrmMantenimientosCentroYsecciones()
        {
            InitializeComponent();
        }

        private void habilitar()
        {
            txtNombre.ReadOnly = false;
        }
        private void deshablitar()
        {
            txtNombre.ReadOnly = true;
        }

        private void btnAgregarCentro_Click(object sender, EventArgs e)
        {
           
        }

        private void refrescar()
        {
            dataGridCentroEducativo.DataSource = null;
            dataGridCentroEducativo.DataSource = centroLogica.seleccionarTodosCentros();
        }

        private void FrmMantenimientosCentroYsecciones_Load(object sender, EventArgs e)
        {
            refrescar();
            deshablitar();
        }

        private void dataGridCentroEducativo_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridCentroEducativo.SelectedRows.Count > 0)
            {
                centro = (CentroEducativo)dataGridCentroEducativo.SelectedRows[0].DataBoundItem;
                txtCodigo.Text = centro.Codigo.ToString();
                txtNombre.Text = centro.Nombre;

                dataGridSeccion.DataSource = centroLogica.seleccionarCentro(centro).listaSeciones;
            }
            deshablitar();
        }

        private void btnAgregarSeccion_Click(object sender, EventArgs e)
        {
          
        }

        private void btnEliminarCentro_Click(object sender, EventArgs e)
        {
        }

        private void btneliminarSeccion_Click(object sender, EventArgs e) {

        }

        private void btnNuevoCentro_Click(object sender, EventArgs e)
        {
          

        }

        public void eliminarSeleccionTabla()
        {
            if (dataGridCentroEducativo.SelectedRows.Count > 0)
            {
                txtNombre.Text = "";
                txtCodigo.Text = "";
                dataGridCentroEducativo.ClearSelection();
                dataGridSeccion.DataSource = null;
                dataGridSeccion.Rows.Clear();
            }
        }

 

        private void dataGridCentroEducativo_MouseClick(object sender, MouseEventArgs e)
        {
            btnNuevaSeccion.Enabled = true;
            btnBorrarSeccion.Enabled = true;
            txtSeccion.Enabled = true;
        }

       

        private void FrmMantenimientosCentroYsecciones_Click(object sender, EventArgs e)
        {
            eliminarSeleccionTabla();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                errorProviderNombreCentro.SetError(txtNombre,"Se requiere el nombre del centro educativo");
            }
            else
            {
                errorProviderNombreCentro.SetError(txtNombre, "");
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            eliminarSeleccionTabla();
            habilitar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            CentroEducativo miCentro = new CentroEducativo();
            miCentro.Nombre = txtNombre.Text;
            if (txtNombre.Text == "")
            {

                errorProviderNombreCentro.SetError(txtNombre, "Nombre del centro requerido");
                txtNombre.Focus();
                return;
            }
            errorProviderNombreCentro.Clear();
            if (txtCodigo.Text != "")
            {
                if (MessageBox.Show(null, "Seguro que desea modificar este registro", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                    try
                    {
                        miCentro.Codigo = Convert.ToInt32(txtCodigo.Text);
                        centroLogica.guardarCentro(miCentro);
                        MessageBox.Show("se modifico correctamente");
                    }
                    catch (Exception a)
                    {
                        MessageBox.Show("error al modificar " + a);
                    }

                }

            }
            else
            {
                try
                {
                    centroLogica.guardarCentro(miCentro);
                    MessageBox.Show("Se agrego correctamente");
                }
                catch (Exception i)
                {

                    MessageBox.Show("error al agregar nuevo registro " + i);
                }

            }
            refrescar();
            deshablitar();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (dataGridCentroEducativo.SelectedRows.Count > 0)
            {
                if (MessageBox.Show(null, "Desea elminar el centro seleccionado?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    centro = (CentroEducativo)dataGridCentroEducativo.SelectedRows[0].DataBoundItem;
                    centroLogica.eliminarCentro(centro);
                    refrescar();
                }

            }
        }

        private void btnNuevaSeccion_Click(object sender, EventArgs e)
        {
            if (dataGridCentroEducativo.SelectedRows.Count > 0)
            {

                if (string.IsNullOrWhiteSpace(txtSeccion.Text))
                {
                    errorProviderSeccion.SetError(txtSeccion, "Se requiere un numero de seccion en el campo");
                    txtSeccion.Focus();
                    return;
                }
                errorProviderSeccion.SetError(txtSeccion, "");

                SeccionLogica seclog = new SeccionLogica();
                Seccion sec = new Seccion();
                sec.Id = txtSeccion.Text;
                seclog.guardar(sec);
                try
                {
                    centro.listaSeciones.Add(sec);
                    centroLogica.guardarCentro(centro);

                    MessageBox.Show("sección agregada correctamente");
                }
                catch (Exception i)
                {

                    MessageBox.Show("error al agregar " + i);
                }

            }
            else
            {
                MessageBox.Show("Seleccione primero el centro al que desea agregar esta sección");
            }
            refrescar();
        }

        private void btnBorrarSeccion_Click(object sender, EventArgs e)
        {

            if (dataGridSeccion.SelectedRows.Count > 0)
            {
                if (MessageBox.Show(null, "Desea eliminar la sección seleccionada?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        Seccion sec = (Seccion)dataGridSeccion.SelectedRows[0].DataBoundItem;
                        new SeccionLogica().eliminarSecciondeUnCentro(centro, sec);
                        refrescar();
                    }
                    catch (Exception i)
                    {
                        MessageBox.Show("error al borrar seccion " + i);
                    }
                }
            }
            else
            {
                MessageBox.Show("Porfavor! seleccione la sección a eliminar");
            }
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
