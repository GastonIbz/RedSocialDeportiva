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

        public DbSet<Home> Home1  { get; set; }
        public BDContext(DbContextOptions options) : base(options)
        {
        }
    }
}
