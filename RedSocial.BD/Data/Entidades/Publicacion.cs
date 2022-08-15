using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedSocial.BD.Data.Entidades
{
    public class Publicacion : EntityBase
    {
        
        
        public string contenidoPublicacion { get; set; }
        public DateTime fechaPublicacion  { get; set; }
    }
}
