using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capas.UI.mantenimientos;
using Capas.UI.reporte;
using Capas.Entidades.usuario;
using Capas.Logica.usuario;
using Capas.Logica.facade;
using Capas.Logica;


namespace slnLibros
{
    public partial class FrmPrincipal : Form
    {

        public Usuario miUsuario { set; get; }
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void centrosEducativosYSeccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

            txtNuevaContrasena.Visible = false;
            txtRepitaContrasena.Visible = false;
            btnGuardar.Visible = false;
            lblGuardarCambios.Visible = false;
            lblNuevaContra.Visible = false;
            lblRepitaContra.Visible = false;
            lblNombreUsuario.Visible = false;
            tramitesEnEsperaToolStripMenuItem1.Visible = false;

            backgroundWorkerNotificar.DoWork += notificar;
            backgroundWorkerNotificar.RunWorkerAsync();

            LogHelper.WriteDebugLog("Inicia la aplicacion");
        }

       private void notificar(object o, DoWorkEventArgs e )
        {
            while (true)
            {
                new TramitarFacade().notificarMorosos();

                System.Threading.Thread.Sleep(60000);

            }
         
           
        }
    


        private void autoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void editorialesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void librosToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void tramitesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void librosPendientesDeDevolucionToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void librosMasPrestadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void estudiantesQueMásSolicitaronToolStripMenuItem_Click(object sender, EventArgs e)
        {
       
        }

        private void codigosQrEstudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void historicoLibrosPrestadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void usuariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void btnMantenimiento_Click(object sender, EventArgs e)
        {
        
           
          
        }

        private void tramitesEnEsperaToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_MouseEnter(object sender, EventArgs e)
        {
        }

        private void panelMantenimiento_MouseLeave(object sender, EventArgs e)
        {
     
        }

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mantenimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void usuariosToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            mantenimientos.FrmMantenimientoUsuarios frm = new mantenimientos.FrmMantenimientoUsuarios();
            frm.Show();
        }

        private void centroEducativoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mantenimientos.FrmMantenimientosCentroYsecciones frm = new mantenimientos.FrmMantenimientosCentroYsecciones();
            frm.Show();
        }

        private void autoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmMantenimientoAutores frm = new FrmMantenimientoAutores();
            frm.Show();
        }

        private void editorialesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmMantenimientoEditoriales frm = new FrmMantenimientoEditoriales();
            frm.Show();
        }

        private void librosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmMantenimientoLibros frm = new FrmMantenimientoLibros();
            frm.Show();
        }

        private void hIstoricoLibrosPrestadosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmReporteLibrosPrestados frm = new FrmReporteLibrosPrestados();
            frm.Usario = this.miUsuario;
            frm.Show();
        }

        private void librosPendientesDevolucionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPendientesDevolucion frm = new FrmPendientesDevolucion();
            frm.Usario = this.miUsuario;
            frm.Show();
        }

        private void libosMasPrestadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReporteLibrosMasPrestados frm = new FrmReporteLibrosMasPrestados();
            frm.Usuario = this.miUsuario;
            frm.Show();
        }

        private void estudiantesQueMasSolicitaronToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEstudiantesMasSolicitaron frm = new FrmEstudiantesMasSolicitaron();
            frm.Usuario = this.miUsuario;
           
            frm.Show();
        }

        private void codigoQREstudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReporteQr frm = new FrmReporteQr();
            
            frm.Show();
        }

        private void gestionarTramitesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Capas.UI.Tramite.FrmTramite frm = new Capas.UI.Tramite.FrmTramite();
            frm.Funcionario = miUsuario;
            frm.Show();
        }

        private void tramitesEnEsperaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Capas.UI.FrmTramiteEspera frm = new Capas.UI.FrmTramiteEspera();
            frm.Show();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
          
            try
            {
                miUsuario = new UsuarioLogica().loginUsuario(txtNombreUsuario.Text,txtContrasena.Text);
            }
            catch (Exception)
            {
                
                throw;
            }

            if (miUsuario==null)
            {
                MessageBox.Show("Nombre de usuario o contraseña incorrectos!");
                return;
            }
            else
            {
                if (miUsuario.primerIngreso==true)
                {
                    txtNuevaContrasena.Visible = true;
                    txtRepitaContrasena.Visible = true;
                    btnGuardar.Visible = true;
                    txtNombreUsuario.ReadOnly = true;
                    txtContrasena.ReadOnly = true;
                    btnEntrar.Enabled = false;

                    lblGuardarCambios.Visible = true;
                    lblNuevaContra.Visible = true;
                    lblRepitaContra.Visible = true;
                  

                }
                else
                {
                    login.Visible = false;

                    lblNombreUsuario.Text =miUsuario.Cedula+" "+ miUsuario.Nombre;
                    lblNombreUsuario.Visible = true;
                    if (miUsuario.GetType().Equals(typeof(Estudiante)))
                    {
                        menuStripMantenimiento.Enabled = false;
                        menuStripReportes.Enabled = false;
                        menuStripConfiguracion.Enabled = false;
                        tramitesEnEsperaToolStripMenuItem1.Visible = false;

                    }
                    else {

                        if (miUsuario.GetType().Equals(typeof(Profesor)))
                        {
                            menuStripMantenimiento.Enabled = false;
                            menuStripReportes.Enabled = false;
                            menuStripConfiguracion.Enabled = false;
                            tramitesEnEsperaToolStripMenuItem1.Visible = true;
                        }
                        else
                        {
                            menuStripMantenimiento.Enabled = true;
                            menuStripReportes.Enabled = true;
                            menuStripConfiguracion.Enabled = true;
                            tramitesEnEsperaToolStripMenuItem1.Visible = true;

                        }


                       

                    }


                }



            }


        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNuevaContrasena.Text.Equals(txtRepitaContrasena.Text))
            {
                try
                {
                    miUsuario.Password = txtRepitaContrasena.Text;
                    miUsuario.primerIngreso = false;
                    
                    new UsuarioLogica().actualizarContrasena(miUsuario);
                    MessageBox.Show("Contraseña actualizada Correctamente!");

                    lblNombreUsuario.Text = miUsuario.Cedula + " " + miUsuario.Nombre;
                    lblNombreUsuario.Visible = true;
                    login.Visible = false;

                    if (miUsuario.GetType().Equals(typeof(Estudiante)))
                    {
                        menuStripMantenimiento.Enabled = false;
                        menuStripReportes.Enabled = false;
                        menuStripConfiguracion.Enabled = false;
                        tramitesEnEsperaToolStripMenuItem1.Visible = false;

                    }
                    else
                    {
                        if (miUsuario.GetType().Equals(typeof(Profesor)))
                        {
                            menuStripMantenimiento.Enabled = false;
                            menuStripReportes.Enabled = false;
                            menuStripConfiguracion.Enabled = false;
                            tramitesEnEsperaToolStripMenuItem1.Visible = true;
                        }
                        else
                        {
                            menuStripMantenimiento.Enabled = true;
                            menuStripReportes.Enabled = true;
                            menuStripConfiguracion.Enabled = true;
                            tramitesEnEsperaToolStripMenuItem1.Visible = true;
                            tramitesEnEsperaToolStripMenuItem1.Visible = true;
                        }


                            ///
                     

                    }
                }
                catch (Exception a)
                {
                    MessageBox.Show("error al cambiar la contraseña "+a.Message);
                    LogHelper.WriteDebugLog("error cambiando contraseña"+a);
                    throw;
                }
            
            }
            else
            {
                MessageBox.Show("las contraseñas no coinciden!");
                return;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            miUsuario = null;
            lblNombreUsuario.Visible = false;
            login.Visible = true;
            txtNombreUsuario.Clear();
            txtContrasena.Clear();
            txtNuevaContrasena.Clear();
            txtRepitaContrasena.Clear();
        }

        private void codigoQRLibrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReporteLibroQr frm = new FrmReporteLibroQr();
            
            frm.Show();
        }

        private void configuracionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Capas.UI.Tramite.FrmConfiguracion frm = new Capas.UI.Tramite.FrmConfiguracion();
            frm.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (miUsuario.GetType().Equals(typeof(Estudiante)))
            {
                Capas.UI.FrmMisGestionesSolicitados frm = new Capas.UI.FrmMisGestionesSolicitados();
                frm.miusuario = this.miUsuario;
                frm.Show();
            }
            else
            {

                Capas.UI.FrmGestionPrestados frm = new Capas.UI.FrmGestionPrestados();
                frm.miUsuario = this.miUsuario;
                frm.Show();
            }
        }
    }

    }

