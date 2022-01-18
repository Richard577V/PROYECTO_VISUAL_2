using Microsoft.EntityFrameworkCore;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloBD
{
    public class Repositorio: DbContext 
    {
        // Configuracion de las entidades
        public DbSet<Estudiante> Estudiantes { get; set; }
        public DbSet<NotaGrado> NotaGrados { get; set; }
        public DbSet<NotaPrueba> NotaPruebas { get; set; }
        public DbSet<Prueba> Pruebas { get; set; }
    }
}
