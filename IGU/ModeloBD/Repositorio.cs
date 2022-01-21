using Microsoft.EntityFrameworkCore;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloBD
{
    public class Repositorio : DbContext
    {
        // Configuracion de las entidades
        public DbSet<Estudiante> Estudiantes { get; set; }
        public DbSet<NotaGrado> NotaGrados { get; set; }
        public DbSet<NotaPrueba> NotaPruebas { get; set; }
        public DbSet<Prueba> Pruebas { get; set; }
        //configuracion de conexion 
        override protected void OnConfiguring(DbContextOptionsBuilder opciones)
        {
             //conexion con sql server
             opciones.UseSqlServer("Server=DESKTOP-EF56O4A; initial catalog=IGU; trusted_connection=true;");

        }
        /*configuracion del modelo 
        protected override void OnModelCreating(ModelBuilder model)
        {
            model.Entity<NotaPrueba>()
                 .HasOne(NotaPrueba => NotaPrueba.Estudiantes)
                 .WithMany();

        }*/

    }
}
