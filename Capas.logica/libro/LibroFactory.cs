using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capas.Entidades.libro;

namespace Capas.Logica.libro
{
    public class LibroFactory
    {

        public Libro crearLibro(string codigo, string titulo,int fecha,Editorial editorial,List<Autor>miLista)
        {
            Libro miLibro = new Libro();

            if (codigo=="")
            {
                miLibro.Codigo = DateTime.Now.Ticks.ToString();
            }
            else
            {
                miLibro.Codigo = codigo;
            }
      
            miLibro.Titulo = titulo;
            miLibro.fechaPublicacion = fecha;
            miLibro.Editorial = editorial;
            if (miLista!=null)
            {
                miLibro.listaAutores = miLista;
            }
           

            return miLibro;
        }
    }
}
