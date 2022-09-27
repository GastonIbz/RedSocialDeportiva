using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedSocial.BD.Data.Entidades
{
    public class Ranking : EntityBase
    {

        [Required]
        public string NickName { get; set; }
        [Required]
        public string Puntos { get; set; }
        [Required]
        public string Partidas { get; set; }
        [Required]
        public string Victorias { get; set; }
        [Required]
        public string PorcentajeDeVictorias { get; set; }




    }
}
