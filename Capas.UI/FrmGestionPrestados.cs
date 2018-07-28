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
    public partial class FrmGestionPrestados : Form
    { 
        public Usuario miUsuario { set; get; }
        public FrmGestionPrestados()
        {
            InitializeComponent();
        }

        private void FrmGestionPrestados_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DBLibrosDataSet3.PA_LibrosPrestados' Puede moverla o quitarla según sea necesario.
            this.PA_LibrosPrestadosTableAdapter.Fill(this.DBLibrosDataSet3.PA_LibrosPrestados,miUsuario.Cedula);

            this.reportViewer1.RefreshReport();
        }
    }
}
