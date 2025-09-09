using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Imagen
    {
        public int IdImagen { get; set; }
        public Articulo Articulo { get; set; }
        public string ImagenUrL { get; set; }
    }
}
