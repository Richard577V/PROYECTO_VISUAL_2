using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Producto
    {
        public int ProductoId { get; set; }
        public string Nombre { get; set; }
        public string Unidad { get; set; }

        //Propiedades de la relacion con oferta_det
        public List<Oferta_Det> Oferta_Det { get; set; }

        //Detalle de la clasificacion
        public List<Clasificacion> Clasificacion { get; set; }
    }
}
