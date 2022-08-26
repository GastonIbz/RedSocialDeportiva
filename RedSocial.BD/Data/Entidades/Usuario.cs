using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedSocial.BD.Data.Entidades
{
    
    public class Usuario : EntityBase
    {
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string Email { get; set; }

        [MaxLength(300, ErrorMessage = "La descripcion no debe superar los {1} caracteres")]
        public string Descripcion { get; set; }  

        //[Required]
        //[Url]
        public string ImgPerfil { get; set; }  

       // [Required]
        //[Url]
        public string ImgPortada { get; set; } 

       

    }
}
