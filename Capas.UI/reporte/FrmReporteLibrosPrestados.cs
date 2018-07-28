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
using Microsoft.Reporting.WinForms;

namespace Capas.UI.reporte
{
    public partial class FrmReporteLibrosPrestados : Form
    {
        public Usuario Usario { get; set; }
        public FrmReporteLibrosPrestados()
        {
            InitializeComponent();
        }

        private void FrmReporteLibrosPrestados_Load(object sender, EventArgs e)
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
            if (txtNombreEst.Text != "")
            {
                filtrosEst += "Nombre, ";
            }
            if (txtPrimerApellido.Text != "")
            {
                filtrosEst += "Primer apellido, ";
            }
            if (txtSegundoApellido.Text != "")
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

            // TODO: esta línea de código carga datos en la tabla 'dBLibrosHistoricoLibros.PA_ReporteLibrosPrestadosHistorico' Puede moverla o quitarla según sea necesario.
            this.pA_ReporteLibrosPrestadosHistoricoTableAdapter.Fill(this.dBLibrosHistoricoLibros.PA_ReporteLibrosPrestadosHistorico, cedula, txtNombreEst.Text, txtPrimerApellido.Text,
            txtSegundoApellido.Text, txtCodigo.Text, txtTitulo.Text);




            ReportParameter nombreUsuario = new ReportParameter("nombreUsuario", "0"/*this.Usario.Nombre+" "+Usario.primerApellido+" "+Usario.SegundoApellido*/);
            ReportParameter filtrosEstudiante = new ReportParameter("filtrosEstudiante", filtrosEst);
            ReportParameter filtrosLibro = new ReportParameter("filtroLibro", filtrosLib);

            reportViewerHistorico.LocalReport.SetParameters(new ReportParameter[] { nombreUsuario,  filtrosLibro, filtrosEstudiante });
            this.reportViewerHistorico.RefreshReport();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
