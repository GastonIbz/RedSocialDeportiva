﻿using Microsoft.EntityFrameworkCore;
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

        public BDContext(DbContextOptions options) : base(options)
        {
        }
        
        public DbSet<Publicacion> TablaPublicacion { get; set; }
    
        public DbSet<Usuario> TablaUsuario { get; set; } 

        public DbSet<EntidadEstadistica> TablaEEntidad { get; set; } 
    }
}
