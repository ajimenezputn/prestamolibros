using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capas.Entidades.qr;

namespace Capas.UI.reporte
{
    public partial class FrmVerQR : Form
    {

       public List<Qr> miLista { set; get; }
        public FrmVerQR()
        {
            InitializeComponent();
        }

        private void FrmVerQR_Load(object sender, EventArgs e)
        {
            QrBindingSource.DataSource = miLista;
            this.reportViewer1.RefreshReport();
        }
    }
}
