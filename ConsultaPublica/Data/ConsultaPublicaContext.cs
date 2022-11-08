using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Models;

namespace ConsultaPublica.Data
{
    public class ConsultaPublicaContext : DbContext
    {
        public ConsultaPublicaContext (DbContextOptions<ConsultaPublicaContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesMovie.Models.Movie> Movie { get; set; } = default!;
    }
}
