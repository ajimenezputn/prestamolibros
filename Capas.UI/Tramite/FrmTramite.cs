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
using Capas.Entidades.libro;
using Capas.Entidades.tramite;
using Capas.Logica.tramites;
using Capas.Logica.facade;
using Capas.Logica.usuario;
using Capas.Logica.libro;
using Microsoft.Reporting.WinForms;
using System.IO;
using System.Data.SqlClient;


namespace Capas.UI.Tramite
{
    public partial class FrmTramite : Form
    {
        TramitarFacade tramitarFacade;
        public Usuario Funcionario { set; get; }
        public static Usuario Estudiante { set; get; }

        public static Libro Libro { set; get; }

        public FrmTramite()
        {
            InitializeComponent();
        }

        private void btnCerrarVentana_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmTramite_Load(object sender, EventArgs e)
        {
           
            mskCodigoEstudiante.Focus();
            tramitarFacade = new TramitarFacade();
            datosFuncionario();   
        }
        private void datosFuncionario()
        {
            if (Funcionario.GetType().Equals(typeof(Estudiante)))
            {
                panelinfoUsuario.Enabled = false;
                mskCodigoEstudiante.Text = Funcionario.Cedula;
                buscarEstudiante();
                mskCodigoEstudiante.ReadOnly = true;
                tramitarFacade.enEspera = true;
                txtCodigoLibro.Focus();

            }
            else
            {

                txtIdUsuario.Text = Funcionario.Cedula;
                txtNombreUsuario.Text = Funcionario.Nombre;
                txtTipoUsuario.Text = Funcionario.ToString();
                tramitarFacade.enEspera = false;

            }

        }

  

        private void refrescar()
        {
              tramitarFacade.asignarLinea();
              dataGridTramites.Rows.Clear();

            foreach (var item in tramitarFacade.ListaTramites)
            {
                string[] row = new string[6];
                row[0] = item.NumeroLinea.ToString();
                if (item.GetType().Equals(typeof(Devolucion)))
                {
                    row[1] = TipoTramite.Devolucion.ToString();
                }
                else
                {
                    row[1] = TipoTramite.Prestamo.ToString();
                }
                row[2] = item.Libro.Codigo.ToString();
                row[3] = item.Libro.Titulo;
               
                row[4] = item.FechaPrestamo.ToString();
                row[5] = item.FechaDevolucion.ToString();

                dataGridTramites.Rows.Add(row);
            }
           
        }

   

      

        private void btnAgregarTramite_Click(object sender, EventArgs e)
        {
            DateTime fecha =Convert.ToDateTime(dateTimeFechaDevolucion.Value.ToShortDateString()+ " " + dateTimeHoraDevolucion.Value.ToShortTimeString());
            ITipoTramite miTramite = new FactoryTramite().crearTramite((TipoTramite)cmbTipoTramite.SelectedItem,Libro,fecha);
            if (Estudiante==null)
            {
                MessageBox.Show(null,"ingrese un estudiante antes de registrar el tramite porfavor!","Atencion!",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                return;
            }
            if (Libro == null)
            {
                MessageBox.Show(null, "Seleccione un libro antes de registrar el tramite porfavor!", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            tramitarFacade.Estudiante =(Estudiante)Estudiante;
            tramitarFacade.Funcionario = Funcionario;

            MessageBox.Show(tramitarFacade.agregarTramite(miTramite));
            
            refrescar();
            dateTimeFechaDevolucion.ResetText();
            dateTimeHoraDevolucion.ResetText();
            txtCodigoLibro.Clear();
            txtNombreLibro.Clear();
            Libro = null;
        }

      

        private void btnBuscarEstudiante_Click(object sender, EventArgs e)
        {
           
           
        }

        private bool buscarEstudiante()
        {
            bool estado = true;
            try
            {
                Estudiante = new UsuarioLogica().selecionarusuario(mskCodigoEstudiante.Text);
             
                if (Estudiante!=null)
                {

                    if (!Estudiante.GetType().Equals(typeof(Estudiante)))
                    {
                        MessageBox.Show(null, "El numero de cedula no corresponde a un estudiante !Verifique he intente denuevo", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Estudiante = null;

                        return estado = false;
                    }
                    txtNombreEstudiante.Text = Estudiante.Nombre + " " + Estudiante.primerApellido + " " + Estudiante.SegundoApellido;
                }
                else
                {
                    MessageBox.Show(null,"No se encontro el estudiante en el sistema","Atención",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return estado = false;
                }
                

            }
            catch (Exception a)
            {

                Logica.LogHelper.WriteDebugLog("error buscando estudiante " + a);
                MessageBox.Show(null, "error " + a.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return estado;
        }

        private void btnBuscarLibro_Click(object sender, EventArgs e)
        {
            buscarLibro();
            txtCodigoLibro.SelectAll();
        }

        private void buscarLibro()
        {
            try
            {
                Libro miLibro = new Libro()
                {
                    Codigo =txtCodigoLibro.Text,
                };
                Libro = new LibroLogica().seleccionarLibro(miLibro);
                if (Libro != null)
                {
                    txtNombreLibro.Text = Libro.Titulo;
                    if (Libro.enPrestamo)
                    {
                        cmbTipoTramite.DataSource = null;
                        cmbTipoTramite.Items.Clear();
                        cmbTipoTramite.Items.Add(TipoTramite.Devolucion);
                        cmbTipoTramite.SelectedIndex = 0;
                    }
                    else
                    {
                        cmbTipoTramite.DataSource = null;
                        cmbTipoTramite.Items.Clear();
                        cmbTipoTramite.Items.Add(TipoTramite.Prestamo);
                        cmbTipoTramite.SelectedIndex = 0;
                    }
                }
                else
                {
                    MessageBox.Show(null, "No se encontro el libro en el sistema!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            catch (Exception a)
            {
                Logica.LogHelper.WriteDebugLog("error buscando libro " + a);
                MessageBox.Show(null, "error "+a.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                

         
            }
        }



        private void txtCodigoLibro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar==(int)Keys.Enter)
            {
                buscarLibro();
                txtCodigoLibro.SelectAll();
            }
        }

      

        private void btnDetalleEstudiante_Click(object sender, EventArgs e)
        {
            if (Estudiante!=null)
            {
                FrmDetalleEstudiante frm = new FrmDetalleEstudiante();
                frm.Estudiante = (Estudiante)Estudiante;
                frm.ShowDialog();
            }
            
        }

        private void btnDetalleLibro_Click(object sender, EventArgs e)
        {
            if (Libro != null)
            {
                Tramite.FmDetalleLibro frm = new Tramite.FmDetalleLibro();
                frm.Libro = Libro;
                frm.ShowDialog();
            }
        }

        private void cmbTipoTramite_Enter(object sender, EventArgs e)
        {
            mskCodigoEstudiante.Focus();
        }

        private void FrmTramite_Activated(object sender, EventArgs e)
        {
            mskCodigoEstudiante.Focus();
        }

        private void cmbTipoTramite_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                if (cmbTipoTramite.SelectedItem.Equals(TipoTramite.Devolucion))
                {
                    lblFecha.Visible = false;
                    lblHora.Visible = false;
                    dateTimeFechaDevolucion.Visible = false;
                    dateTimeHoraDevolucion.Visible = false;
                }
                else
                {
                    lblFecha.Visible = true;
                    lblHora.Visible = true;
                    dateTimeFechaDevolucion.Visible = true;
                    dateTimeHoraDevolucion.Visible = true;
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

        private void btnNuevoTramite_Click(object sender, EventArgs e)
        {
            if (Funcionario.GetType().Equals(typeof(Estudiante)))
            {

                dataGridTramites.Rows.Clear();
                reportViewerFactura.Clear();

                panelTramites.Enabled = true;
                panelTitulo.Enabled = true;
                txtCodigoLibro.Focus();

            }
            else
            {

                tramitarFacade = new TramitarFacade();
                Estudiante = null;
                Libro = null;
                mskCodigoEstudiante.ReadOnly = false;
                dataGridTramites.Rows.Clear();
                reportViewerFactura.Clear();

                panelTramites.Enabled = true;
                panelTitulo.Enabled = true;

                limpiarControles();
                mskCodigoEstudiante.Focus();

            }


            
        }

        private void mskCodigoEstudiante_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                if (buscarEstudiante())
                {
                    txtCodigoLibro.Focus();
                    mskCodigoEstudiante.ReadOnly = true;
                }
                else
                {
                    mskCodigoEstudiante.SelectAll();
                }

            }
        }

        private void btnEliminarTramite_Click(object sender, EventArgs e)
        {
            if (dataGridTramites.SelectedRows.Count>0)
            {
                try
                {
                    tramitarFacade.eliminarTramite(Convert.ToInt32(dataGridTramites.SelectedRows[0].Cells[0].Value));
                    refrescar();
                    MessageBox.Show(null,"Tramite Eliminado Correctamente!","Atencion!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                catch(Exception a)
                {
                    Logica.LogHelper.WriteDebugLog("error eliminando tramite " + a);
                    MessageBox.Show(null, "Error al eliminar !"+a.Message, "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
            }
            else
            {
                MessageBox.Show(null, "Seleccione antes el tramite a eliminar", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBuscarEstudiantes_Click(object sender, EventArgs e)
        {
            if (buscarEstudiante())
            {
                mskCodigoEstudiante.ReadOnly = true;
            }
            else
            {
                mskCodigoEstudiante.SelectAll();
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (dataGridTramites.RowCount>0)
            {
                int enc = tramitarFacade.guardarComprobante();
                // TODO: esta línea de código carga datos en la tabla 'dBLibrosDataSet.PA_reporteVerComprobante' Puede moverla o quitarla según sea necesario.
                this.pA_reporteVerComprobanteTableAdapter.Fill(this.dBLibrosDataSet.PA_reporteVerComprobante, enc);
                this.reportViewerFactura.RefreshReport();
          
                MessageBox.Show(null, tramitarFacade.EnviarCorreo((Estudiante)Estudiante, this.reportViewerFactura.LocalReport), "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                panelTramites.Enabled = false;
                panelTitulo.Enabled = false;

                btnNuevoTramite.Focus();
             
            }
            else
            {
                MessageBox.Show(null, "No existen tramites agregados ! porfavor agreguelos antes de continuar!", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
       



        }
      
        public void limpiarControles()
        {
            mskCodigoEstudiante.Clear();
            txtNombreEstudiante.Clear();
            txtNombreLibro.Clear();
            txtCodigoLibro.Clear();
        }

        private void btnBusquedaAvanzadaEstudiante_Click(object sender, EventArgs e)
        {
            FrmBusquedaAvanzadaEstudiante frm = new FrmBusquedaAvanzadaEstudiante();
            Estudiante = frm.miUsuario;
            DialogResult resultado = frm.ShowDialog();
            if (resultado==DialogResult.OK)
            {
                mskCodigoEstudiante.Text = Estudiante.Cedula;
                txtNombreEstudiante.Text = Estudiante.Nombre + " " + Estudiante.primerApellido + " " + Estudiante.SegundoApellido;
                mskCodigoEstudiante.ReadOnly = true;
                txtCodigoLibro.Focus();
            }
        }

        private void btnBusquedaAvanzadaLibro_Click(object sender, EventArgs e)
        {
            FrmBusquedaAvanzadaLibro frm = new FrmBusquedaAvanzadaLibro();
            DialogResult resultado = frm.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                txtCodigoLibro.Text = Libro.Codigo;
                buscarLibro();
            }

        }
    }
}
