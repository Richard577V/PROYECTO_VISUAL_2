using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class NotaPrueba
    {
        public int NotaPruebaId { get; set; }
        // Relación con estudiante
        public List<Estudiante> Estudiantes { get; set; }
        // Relación Uno a Uno
        public Prueba Prueba { get; set; }
        // Composición de las notas
        public List<NotaGrado> NotaGrados { get; set; }
        public List<Prueba> Pruebas { get; set; }

    }
}
