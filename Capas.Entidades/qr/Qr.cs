using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capas.Entidades.qr
{
   public class Qr
    {
     public string Id { set; get; }
     public string Nombre { set; get; }

     public byte[] CodigoQr { set; get; }
    }
}
