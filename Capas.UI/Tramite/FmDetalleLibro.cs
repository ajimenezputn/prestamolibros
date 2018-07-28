using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capas.Entidades.libro;
using Capas.Logica.libro;
namespace Capas.UI.Tramite
{
    public partial class FmDetalleLibro : Form
    {  
       public Libro Libro { set; get; }
        public FmDetalleLibro()
        {
            InitializeComponent();
        }

        private void FmDetalleLibro_Load(object sender, EventArgs e)
        {
            txtCodigo.Text = Libro.Codigo.ToString();
            txtTitulo.Text = Libro.Titulo;
            txtEditorial.Text = Libro.Editorial.Nombre;
            txtFecha.Text = Libro.fechaPublicacion.ToString();
            dataGridAutores.DataSource = new LibroLogica().todosLosAutoresPorLibro(Libro.Codigo);

        }
    }
}
