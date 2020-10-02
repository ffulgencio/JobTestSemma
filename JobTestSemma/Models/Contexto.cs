using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobTestSemma.Models
{
    public class Contexto: DbContext
    {
        public DbSet<Socio> Socios { get; set; }
        public DbSet<Barco> Barcos { get; set; }
        //public DbSet<Patron> Patrons { get; set; }
        //public DbSet<Salida> Salidas { get; set; }

        public Contexto(DbContextOptions<Contexto> options ): base(options)
        {

        }
    }
}
