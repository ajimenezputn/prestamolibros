using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Capas.Entidades.libro
{
   public  class Libro
    {  public string Codigo { set; get; }
       public string Titulo { set; get; }
       
       public bool enPrestamo { set; get; }
        public int fechaPublicacion { set; get; }
        public List<Autor> listaAutores { set; get;}
        public Editorial Editorial { set; get; }

        public Libro()
        {
            listaAutores = new List<Autor>();
        }

    }
}
