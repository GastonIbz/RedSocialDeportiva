using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedSocial.BD.Data.Entidades
{
    public class Publicacion : EntityBase
    {
        [Required]
        [MaxLength(50)]
        public string Usuario { get; set; }
        [Required]
        [StringLength(100)]
        public string ContenidoPublicacion { get; set; }
        public DateTime FechaPublicacion  { get; set; }
        public int MeGusta { get; set; }
        public int VecesCompartido { get; set; }
        public bool EsPrivada { get; set; }
    }
}
