using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capas.UI
{
    public partial class FrmverDetalle : Form
    {

        public int idEncabezado { set; get; }
        public FrmverDetalle()
        {
            InitializeComponent();
        }

        private void FrmverDetalle_Load(object sender, EventArgs e)
        {
            refrescar(); 
        }

        private void refrescar()
        {
            dataGridView1.Rows.Clear();

            string[] info = new string[5];
            foreach (var item in  new Logica.comprobante.ComprobanteLogica().listaDetalles(idEncabezado))
            {
                info[0] = item.Libro.Codigo.ToString();
                info[1] = item.Libro.Titulo;
                info[2] = item.tipo.ToString();
                info[3] = item.fechaPrestamo.ToString();
                info[4] = item.fechaDevolucion.ToString();

                dataGridView1.Rows.Add(info);
            }
        }
    }
}
