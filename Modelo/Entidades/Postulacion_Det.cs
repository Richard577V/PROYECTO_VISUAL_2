using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Postulacion_Det
    {
        public int Postulacion_DetId { get; set; }
        public string Nombre { get; set; }

        //Propiedades de la relacion con postulacion
        public Postulacion Postulacion{ get; set; }
        public int PostulacionId { get; set; }

        

        //Propiedades de la relacion con calificaicon
        public Calificacion Calificacion { get; set; }
       


    }
}
