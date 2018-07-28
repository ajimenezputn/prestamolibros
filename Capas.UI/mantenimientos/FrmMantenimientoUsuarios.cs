using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capas.Entidades.enums;
using Capas.Entidades.usuario;
using Capas.Logica.usuario;
using Capas.Logica;



namespace slnLibros.mantenimientos
{
    public partial class FrmMantenimientoUsuarios : Form
    {

        public FrmMantenimientoUsuarios()
        {
            InitializeComponent();
        }

        private void FrmMantenimientoUsuarios_Load(object sender, EventArgs e)
        {
            cargarTipoUsuario();
            cargarCentroEducativoSeccion();
            cargarGeneros();
            refrescar();
            desahiblitar();
        }

        private void habilitar()
        {
            mskCedula.ReadOnly = false;
            txtNombre.ReadOnly = false;
            txtPrimerApellido.ReadOnly = false;
            txtSegundoApellido.ReadOnly = false;
            mskTelefono.ReadOnly = false;
            txtCorreo.ReadOnly = false;
            cmbGenero.Enabled = true;
            dateTimeFechaNacimiento.Enabled = true;
            cmbTipoUsuario.Enabled = true;
            cmbCentroEducativo.Enabled = true;
            cmbSeccion.Enabled = true;
        }
        private void desahiblitar()
        {
            mskCedula.ReadOnly = true;
            txtNombre.ReadOnly = true;
            txtPrimerApellido.ReadOnly = true;
            txtSegundoApellido.ReadOnly = true;
            mskTelefono.ReadOnly = true;
            txtCorreo.ReadOnly = true;
            cmbGenero.Enabled = false;
            dateTimeFechaNacimiento.Enabled = false;
            cmbTipoUsuario.Enabled = false;
            cmbCentroEducativo.Enabled = false;
            cmbSeccion.Enabled = false;
        }
        private void cargarGeneros()
        {
            cmbGenero.DataSource = Enum.GetValues(typeof(Genero));

        }

        private void cargarCentroEducativoSeccion()
        {
            cmbCentroEducativo.DataSource = new CentroEducativoLogica().seleccionarTodosCentros();
            cmbCentroEducativo.DisplayMember = "nombre";


        }

        private void cargarTipoUsuario()
        {
            cmbTipoUsuario.DataSource = Enum.GetValues(typeof(TipoUsuario));
        }

        private void cmbCentroEducativo_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Seccion> milista = ((CentroEducativo)cmbCentroEducativo.SelectedValue).listaSeciones;
            cmbSeccion.DataSource = null;
            cmbSeccion.DataSource = milista;
            cmbSeccion.DisplayMember = "Id";


        }

        private void cmbTipoUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoUsuario.SelectedItem.Equals(TipoUsuario.Administrador))
            {
                cmbCentroEducativo.Visible = false;
                cmbSeccion.Visible = false;
                lblCentroEducativo.Visible = false;
                lblSeccion.Visible = false;
            }
            else
            {
                if (cmbTipoUsuario.SelectedItem.Equals(TipoUsuario.Estudiante))
                {
                    cmbCentroEducativo.Visible = true;
                    cmbSeccion.Visible = true;
                    lblCentroEducativo.Visible = true;
                    lblSeccion.Visible = true;
                }
                else
                {
                    if (cmbTipoUsuario.SelectedItem.Equals(TipoUsuario.Profesor))
                    {
                        cmbCentroEducativo.Visible = true;
                        cmbSeccion.Visible = false;
                        lblCentroEducativo.Visible = true;
                        lblSeccion.Visible = false;

                    }

                }

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {



        }

        /// <summary>
        /// actualiza la tabla
        /// </summary>
        private void refrescar()
        {
            dataGridUsuarios.Rows.Clear();
            foreach (var item in new UsuarioLogica().todosLosUsario())
            {
                string[] row = new string[11];
                row[0] = item.Cedula;
                row[1] = item.Nombre;
                row[2] = item.primerApellido;
                row[3] = item.SegundoApellido;
                row[4] = item.NumeroTelefono;
                row[5] = item.CorreoElectronico;
                row[6] = item.Genero.ToString();
                row[7] = item.FechaNacimiento.ToString();
                row[8] = item.ToString();

                if (item.GetType().Equals(typeof(Estudiante)))
                {
                    row[9] = ((Estudiante)item).CentroEducativo.Nombre;
                    row[10] = ((Estudiante)item).Seccion.Id;
                }
                else
                {
                    if (item.GetType().Equals(typeof(Profesor)))
                    {
                        row[9] = ((Profesor)item).CentroEducativo.Nombre;
                    }

                }

                dataGridUsuarios.Rows.Add(row);

            }
        }

        private void btnCerrarVentana_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void dataGridUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridUsuarios.SelectedRows.Count > 0 && dataGridUsuarios.RowCount > 1 && (string)dataGridUsuarios.SelectedRows[0].Cells[0].Value != null)
            {
                Usuario miUsario = new UsuarioLogica().selecionarusuario(((string)dataGridUsuarios.SelectedRows[0].Cells[0].Value).Trim());
                mskCedula.Text = miUsario.Cedula;
                txtNombre.Text = miUsario.Nombre;
                txtPrimerApellido.Text = miUsario.primerApellido;
                txtSegundoApellido.Text = miUsario.SegundoApellido;
                mskTelefono.Text = miUsario.NumeroTelefono;
                txtCorreo.Text = miUsario.CorreoElectronico;
                cmbGenero.SelectedItem = miUsario.Genero;
                dateTimeFechaNacimiento.Value = miUsario.FechaNacimiento;
              

                TipoUsuario tipo;
                Enum.TryParse(miUsario.ToString(), out tipo);
                cmbTipoUsuario.SelectedItem = tipo;

                if (miUsario.GetType().Equals(typeof(Estudiante)))
                {

                    selecionarComboCentro(((Estudiante)miUsario).CentroEducativo);
                    selecionarComboSeccion(((Estudiante)miUsario).Seccion);

                }
                else
                {
                    if (miUsario.GetType().Equals(typeof(Profesor)))
                    {

                        selecionarComboCentro(((Profesor)miUsario).CentroEducativo);
                    }

                }
                desahiblitar();
            }
        }

        private void selecionarComboCentro(CentroEducativo centro)
        {

            for (int i = 0; i < cmbCentroEducativo.Items.Count; i++)
            {
                cmbCentroEducativo.SelectedIndex = i;

                if (((CentroEducativo)cmbCentroEducativo.SelectedItem).Codigo.Equals(centro.Codigo))
                {
                    return;
                }

            }
        }

        private void selecionarComboSeccion(Seccion sec)
        {
            for (int i = 0; i < cmbSeccion.Items.Count; i++)
            {
                cmbSeccion.SelectedIndex = i;

                if (((Seccion)cmbSeccion.SelectedItem).Id.Equals(sec.Id))
                {
                    return;


                }

            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (dataGridUsuarios.SelectedRows.Count > 0 && dataGridUsuarios.RowCount > 1)
            {
                if (MessageBox.Show(null, "Desea eliminar el registro!?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question).Equals(DialogResult.Yes))
                {
                    try
                    {
                        new UsuarioLogica().eliminarUsuario(((string)dataGridUsuarios.SelectedRows[0].Cells[0].Value).Trim());
                        MessageBox.Show("Borrado con exito!");
                    }
                    catch (Exception a)
                    {
                        LogHelper.WriteDebugLog("error eliminado usuario " + a.Message);
                        MessageBox.Show(null,"Error al borrar ! " + a.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                    finally
                    {
                        refrescar();
                    }

                }
            }
            else
            {
                MessageBox.Show(null, "Selecciona el registro que desea eliminar!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (!mskCedula.MaskFull)
            {
                MessageBox.Show(null, "Por favor! escriba un numero de cedula!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                mskCedula.Focus();
                return;
            }
            Usuario miUsuario = new UsuarioFactory().crearUsuario(mskCedula.Text, txtNombre.Text, txtPrimerApellido.Text,
            txtSegundoApellido.Text, dateTimeFechaNacimiento.Value, (Genero)cmbGenero.SelectedItem,
            mskTelefono.Text, txtCorreo.Text, (CentroEducativo)cmbCentroEducativo.SelectedItem, (Seccion)cmbSeccion.SelectedItem, (TipoUsuario)cmbTipoUsuario.SelectedItem);
            try
            {
           
                MessageBox.Show(null, new UsuarioLogica().insertarUsuario(miUsuario) , "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception a)
            {
                LogHelper.WriteDebugLog("error agregando usuario " + a.Message);
                MessageBox.Show(null, "Error al guardar! " + a, "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                refrescar();
                desahiblitar();
            }

        }

        private void btnNuevoUsuario_Click_1(object sender, EventArgs e)
        {
            dataGridUsuarios.ClearSelection();
            mskCedula.ResetText();
            txtNombre.Clear();
            txtPrimerApellido.Clear();
            txtSegundoApellido.Clear();
            mskTelefono.ResetText();
            txtCorreo.Clear();
            dateTimeFechaNacimiento.ResetText();
            habilitar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            habilitar();
        }

        private void btnCambiarContraseña_Click(object sender, EventArgs e)
        {
            if (dataGridUsuarios.SelectedRows.Count>0)
            {
                if ((MessageBox.Show(null, "Desea restablecer la contraseña del usuario seleccionado!?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question).Equals(DialogResult.Yes)))
                {
                    try
                    {
                        Usuario miUsuario = new UsuarioLogica().selecionarusuario(((string)dataGridUsuarios.SelectedRows[0].Cells[0].Value).Trim());
                        miUsuario.Password = new UsuarioLogica().crearContrasenas();
                        miUsuario.primerIngreso = true;
                        new UsuarioLogica().actualizarContrasena(miUsuario);
                        MessageBox.Show(null, "Contraseña restablecida con exito!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MessageBox.Show(null,new UsuarioLogica().EnviarCorreo(miUsuario) , "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception a)
                    {

                       LogHelper.WriteDebugLog("error restableciendo contraseña de usuario " + a.Message);
                        MessageBox.Show(null, "Error al restablecer la contraseña " + a.Message, "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                       
                    }
                }
            }
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
    

