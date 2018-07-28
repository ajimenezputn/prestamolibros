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

namespace Capas.UI.mantenimientos
{
    public partial class FrmLibroAutor : Form
    {
        public Libro Libro { get; set; }
        public FrmLibroAutor()
        {
            InitializeComponent();
        }

        private void FrmLibroAutor_Load(object sender, EventArgs e)
        {
            lblNombreLibro.Text = lblNombreLibro.Text+" "+ Libro.Titulo;
        
            refrescar();
        }

        private void refrescar()
        {
            dataGridAutores.DataSource = null;
            dataGridAutores.DataSource = Libro.listaAutores;
            listAutores.DataSource = null;
            listAutores.DataSource = new AutorLogica().listaAutoresNoSelecionados(Libro);
            listAutores.DisplayMember = "nombre";
        }

        private void btnAgregarAutor_Click(object sender, EventArgs e)
        {
            if (listAutores.SelectedItem!=null)
            {
                Libro.listaAutores.Add((Autor)listAutores.SelectedItem);
                try
                {
                    new LibroLogica().guardarLibroAutor(Libro, (Autor)listAutores.SelectedItem);
                    MessageBox.Show(null, "Se agrego correctamente!", "Agregar Autor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception a)
                {

                    Logica.LogHelper.WriteDebugLog("error agregando autor "+a);
                    MessageBox.Show(null, "Error al agregar Autor ! "+a.Message, "Agregar Autor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                refrescar();
            }
            else
            {
                MessageBox.Show(null,"Seleccione el autor que desea agregar","Agregar Autor",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridAutores.SelectedRows.Count>0)
            {
               


                if (MessageBox.Show(null, "Desea eliminar este autor?", "Eliminar Autor", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    Autor miAutor = (Autor)dataGridAutores.SelectedRows[0].DataBoundItem;

                    try
                    {
                        Libro.listaAutores.Remove(miAutor);
                        new LibroLogica().eliminarLibroAutor(Libro,miAutor);
                        refrescar();
                        MessageBox.Show(null, "Se elimino correctamente", "Eliminar Autor", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch (Exception a)
                    {
                        Logica.LogHelper.WriteDebugLog("error eliminando autor" + a);
                        MessageBox.Show(null, "Error al eliminar autor !"+a.Message, "Eliminar Autor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                      
                    }
                 
                 

                }

            }
        }
    }
}
