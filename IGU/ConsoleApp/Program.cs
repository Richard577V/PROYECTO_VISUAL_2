using Modelo;
using ModeloBD;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //creacion de Estudiantes 
            Estudiante Richard = new Estudiante() { Nombre = "Richard Altamirano", email = "8altari@gmail.com" };
           
            //Nota de grado

            NotaGrado notabachiller1 = new NotaGrado()
            {
                Estudiante = Richard,
                Nota1 = 7
            };

            //Grabar la informacion 
            Repositorio repos = new Repositorio();

            repos.Estudiantes.AddRange(Richard);
            repos.NotaGrados.AddRange(notabachiller1);
            repos.SaveChanges();
        }
    }
}
