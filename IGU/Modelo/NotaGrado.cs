using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class NotaGrado
    {
        public int NotaGradoId { get; set; }
        // Composición de las notas
        public float Nota1 { get; set; }
        // Relación Uno a Uno
        public int estudianteid { get; set; }
        public Estudiante Estudiante { get; set; }
    }
}
