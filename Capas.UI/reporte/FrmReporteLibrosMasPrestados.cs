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
    public partial class FrmReporteLibrosMasPrestados : Form
    {    
        public Usuario Usuario { set; get; }
        public FrmReporteLibrosMasPrestados()
        {
            InitializeComponent();
        }

        private void FrmReporteLibrosMasPrestados_Load(object sender, EventArgs e)
        {

            ReportParameter nombreUsuario = new ReportParameter("nombreUsuario", this.Usuario.Nombre+" "+Usuario.primerApellido+" "+Usuario.SegundoApellido);
     

            reportViewer1.LocalReport.SetParameters(new ReportParameter[] { nombreUsuario });
            // TODO: esta línea de código carga datos en la tabla 'dBLibrosmasPrestados.PA_ReporteLibrosMasPrestado' Puede moverla o quitarla según sea necesario.
            this.pA_ReporteLibrosMasPrestadoTableAdapter.Fill(this.dBLibrosmasPrestados.PA_ReporteLibrosMasPrestado);
  
            this.reportViewer1.RefreshReport();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
