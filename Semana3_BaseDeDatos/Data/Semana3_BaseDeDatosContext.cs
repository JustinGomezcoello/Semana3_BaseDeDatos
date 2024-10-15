using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Semana3_BaseDeDatos.Models;

namespace Semana3_BaseDeDatos.Data
{
    public class Semana3_BaseDeDatosContext : DbContext
    {
        public Semana3_BaseDeDatosContext (DbContextOptions<Semana3_BaseDeDatosContext> options)
            : base(options)
        {
        }

        public DbSet<Semana3_BaseDeDatos.Models.Estudiante> Estudiante { get; set; } = default!;
    }
}
