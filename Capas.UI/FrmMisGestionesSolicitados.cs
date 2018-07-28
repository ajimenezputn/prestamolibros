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

namespace Capas.UI
{
    public partial class FrmMisGestionesSolicitados : Form
    {
        public Usuario miusuario;
        public FrmMisGestionesSolicitados()
        {
            InitializeComponent();
        }

        private void FrmMisGestiones_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DBLibrosDataSet2.PA_LibrosSolicitados' Puede moverla o quitarla según sea necesario.
            this.PA_LibrosSolicitadosTableAdapter.Fill(this.DBLibrosDataSet2.PA_LibrosSolicitados,miusuario.Cedula);

            this.reportViewer1.RefreshReport();
        }
    }
}
