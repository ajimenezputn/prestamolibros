using Microsoft.Reporting.WinForms;
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

namespace Capas.UI.reporte
{
    public partial class FrmPendientesDevolucion : Form
    {  
        public Usuario Usario { get; set; }
        public FrmPendientesDevolucion()
        {
            InitializeComponent();
        }

        private void FrmPendientesDevolucion_Load(object sender, EventArgs e)
        {

        }
        private void btnBuscarEstudiantes_Click(object sender, EventArgs e)
        {
            string filtrosEst = "";
            string filtrosLib = "";
            string cedula = "";
            if (mskCedulaEstudiante.MaskFull)
            {
                cedula = mskCedulaEstudiante.Text;
                filtrosEst += "Cedula, ";
            }
            if (txtNombreEst.Text!="")
            {
                filtrosEst += "Nombre, ";
            }
            if (txtPrimerApellido.Text !="")
            {
                filtrosEst += "Primer apellido, ";
            }
            if (txtSegundoApellido.Text !="")
            {
                filtrosEst += "Segundo apellido, ";
            }
            if (txtCodigo.Text != "")
            {
                filtrosLib += "Codigo, ";
            }
            if (txtTitulo.Text != "")
            {
                filtrosLib += "Titulo, ";
            }

            try
            {
                // TODO: esta línea de código carga datos en la tabla 'dBLibrosDataSet1.PA_ReporteLibrosPendientesDevolucion' Puede moverla o quitarla según sea necesario.
                this.pA_ReporteLibrosPendientesDevolucionTableAdapter.Fill(this.dBLibrosDataSet1.PA_ReporteLibrosPendientesDevolucion, cedula, txtNombreEst.Text, txtPrimerApellido.Text,
                    txtSegundoApellido.Text, txtCodigo.Text, txtTitulo.Text
                       );


                ReportParameter nombreUsuario = new ReportParameter("nombreUsuario", this.Usario.Nombre+" "+Usario.primerApellido+" "+Usario.SegundoApellido);
                ReportParameter filtrosEstudiante = new ReportParameter("filtrosEstudiante", filtrosEst);
                ReportParameter filtrosLibro = new ReportParameter("filtrosLibros", filtrosLib);

                reportViewer1.LocalReport.SetParameters(new ReportParameter[] { nombreUsuario, filtrosEstudiante, filtrosLibro });

                this.reportViewer1.RefreshReport();

            }
            catch (Exception a)
            {
                Logica.LogHelper.WriteDebugLog("error reporte pendientes de devolucion " + a);
                throw;
            }
         
            }
    

    private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnCerrarVentana_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void header_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
