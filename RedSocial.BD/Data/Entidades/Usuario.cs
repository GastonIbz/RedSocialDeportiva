using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedSocial.BD.Data.Entidades
{
    [Index(nameof(Id), Name = "IdUsuario_UQ", IsUnique = true)]
    public class Usuario
    {
        public int Id { get; set; } 
        public string NameUsuario { get; set; }
        public string password { get; set; } 

        public string Email { get; set; } 

        public string Descripcion { get; set; } 

    }
}
