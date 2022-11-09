using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedSocial.BD.Data.Entidades
{

    [Index(nameof(id), Name = "IdEstadistica_UQ", IsUnique = true)]
    public class EntidadEstadistica 
    { 
        public int id { get; set; }
        public string Username { get; set; }

        public string NombreEquipo { get; set; }

        public string JuegoProfesional { get; set; }

        public string PosicionMundial { get; set; }

        public string PosicionPaisNatal { get; set; }

        public string PartidasJugadas { get; set; }

        public string Ganadas { get; set; }

        public string Perdidas { get; set; }

        public string empatadas { get; set; }

        public string MVP { get; set; }

        public string MayorLogro { get; set; }

        public string Horas { get; set; }

    } 
}
