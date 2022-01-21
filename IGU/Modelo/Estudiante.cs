using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Estudiante
    {
        // Atributos
        public int estudianteid { get; set; }
        public string Nombre { get; set; }
        public string email { get; set; }

        // Relación con NotaPrueba
        public List<NotaPrueba> NotaPruebas { get; set; }

    }
}

