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
    public partial class FrmVerQrLibro : Form
    {
        public List<Qr> miLista = new List<Qr>();
        public FrmVerQrLibro()
        {
            InitializeComponent();
        }

        private void FrmVerQrLibro_Load(object sender, EventArgs e)
        {
            QrBindingSource.DataSource = miLista;
            this.reportViewer1.RefreshReport();
        }
    }
}
