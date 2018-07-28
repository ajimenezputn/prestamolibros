using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capas.Entidades.qr;
using System.IO;
using System.Drawing;
using Capas.Entidades.usuario;
using Capas.Entidades.libro;
using ZXing;


namespace Capas.Logica.qrLogica
{
   public class QrLogica
    {

       public List<Qr> listaQrEstudiantes;

        public List<Qr> listaQrLibros;

        public QrLogica()
        {
            listaQrEstudiantes = new List<Qr>();
            listaQrLibros = new List<Qr>();
        }


        private byte[] convertirImagenBits(Image imagen)
        {
            using (var stream = new MemoryStream())
            {    
                imagen.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                return stream.ToArray();
            }
        }

        private Image crearQr(string id)
        {
            BarcodeWriter writer = new BarcodeWriter();
            writer.Format = BarcodeFormat.QR_CODE;
            

            Image imagen = new Bitmap(writer.Write(id));


            return imagen;
        }

       public void agregarQr(Estudiante est)
        {
            Qr miQr = new Qr();
            miQr.Id = est.Cedula;
            miQr.Nombre = est.Nombre + " " + est.primerApellido + " " + est.SegundoApellido;
            miQr.CodigoQr = convertirImagenBits(crearQr(est.Cedula));

            listaQrEstudiantes.Add(miQr);
        }

        public void agregarQr(Libro libro)
        {
            Qr miQr = new Qr();
            miQr.Id = libro.Codigo;
            miQr.Nombre = libro.Titulo;
            miQr.CodigoQr = convertirImagenBits(crearQr(libro.Codigo));

            listaQrLibros.Add(miQr);
        }

    }
}
