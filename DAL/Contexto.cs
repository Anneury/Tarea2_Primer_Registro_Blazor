using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tarea2_Primer_Registro_Blazor.Models;

namespace Tarea2_Primer_Registro_Blazor.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Personas> Personas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = Data\DatosPersonas.db");
        }
    }
}
