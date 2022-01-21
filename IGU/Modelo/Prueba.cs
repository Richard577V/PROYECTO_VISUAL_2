using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Prueba
    {
        public int PruebaId { get; set; }
        public string Nombre { get; set; }
        public string materia { get; set; }

        // Relación con nota de grado para verificar
        public List<NotaGrado> NotaGrados { get; set; }
    
        // Composición de las notas
        public float Nota1 { get; set; }
        public float Nota2 { get; set; }
        public float Nota3 { get; set; }
        public float Nota4 { get; set; }

        // Cálculo de la nota final
        public float NotaFinal(float peso1, float peso2, float peso3, float peso4)
        {
            // Cálculo
            float suma = 0;
            suma += MathF.Round(Nota1 * peso1, 2);
            suma += MathF.Round(Nota2 * peso2, 2);
            suma += MathF.Round(Nota3 * peso3, 2);
            suma += MathF.Round(Nota4 * peso4, 2);
            suma = MathF.Round(suma, 2);
            return suma;
        }
        // Verifica si cumple el mínimo
        public bool Aprueba(float peso1, float peso2, float peso3, float peso4, float NotaMinima)
        {
            bool res;
            res = NotaFinal(peso1, peso2, peso3, peso4) >= NotaMinima;
            return res;
        }
    }
}
