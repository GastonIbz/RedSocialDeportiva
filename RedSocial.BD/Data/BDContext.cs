using Microsoft.EntityFrameworkCore;
using RedSocial.BD.Data.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedSocial.BD.Data
{
    public class BDContext : DbContext
    {

        public DbSet<Estadistica> Estadisticas  { get; set; }
        public DbSet<Publicacion> Publicaciones { get; set; }
        public DbSet<Ranking>   Rankings { get; set; }
        public DbSet<Usuario>   Usuarios { get; set; }
        public BDContext(DbContextOptions options) : base(options)
        {
        }
    }
}
