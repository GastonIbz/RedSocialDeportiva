using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedSocial.BD.Data.Entidades
{
    public class Relacion : EntityBase
    {
        public int idUsuario { get; set; } 
        public Usuario usuario { get; set; }

        public List<Usuario> Usuarios { get; set; }
    }
}
