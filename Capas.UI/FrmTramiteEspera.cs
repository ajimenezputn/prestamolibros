using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capas.Entidades.comprobante;
using Capas.Logica.comprobante;

namespace Capas.UI
{
    public partial class FrmTramiteEspera : Form
    {
        public FrmTramiteEspera()
        {
            InitializeComponent();
        }

        private void FrmTramiteEspera_Load(object sender, EventArgs e)
        {
            refrescar();
        }

        private void refrescar()
        {
            dataGridView1.Rows.Clear();
            string[] info = new string[5];

            foreach (var item in new ComprobanteLogica().listaDeEncabezadosEspera())
            {
                info[0] = item.id.ToString();
                info[1] = item.Estudiante.Cedula;
                info[2] = item.Estudiante.Nombre + " " + item.Estudiante.primerApellido + " " + item.Estudiante.SegundoApellido;
                info[3] = item.fecha.ToString();

                dataGridView1.Rows.Add(info);
            }
        }

        private void btnAutorizar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count>0)
            {

                if (MessageBox.Show(null,"Desea autorizar este tramite!","Atencion!",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    EncabezadoComprobante comprobante = new EncabezadoComprobante();
                    comprobante.id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

                    new ComprobanteLogica().actualizarComprobante(comprobante);

                    refrescar();
                }
           
            }
        }

        private void btnVerDetalle_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count>0)
            {
             FrmverDetalle frm= new FrmverDetalle();
                
                frm.idEncabezado = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                frm.ShowDialog();
            }
        }
    }
}
