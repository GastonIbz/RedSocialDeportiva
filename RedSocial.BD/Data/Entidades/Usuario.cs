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

        [Required]
        [MaxLength(30, ErrorMessage = "El nombre de usuario no debe superar los {1} caracteres")]
        public string NameUsuario { get; set; }

        [Required] 
        [MinLength(8, ErrorMessage = "la contraseña debe tener al menos {1} caracteres")] 
        [DataType(DataType.Password)]   
        public string password { get; set; } 

        [DataType(DataType.Password)]
        public string COnfirmPassword { get; set; }

        
        [Required]
        [EmailAddress] 
        [StringLength(100, ErrorMessage = "El {0} debe tener al menos {1} caracter",MinimumLength=1)]
        public string Email { get; set; }

        [MaxLength(300, ErrorMessage = "La descripcion no debe superar los {1} caracteres")]
        public string Descripcion { get; set; }  

        [Required]
        [Url]
        public string ImgPerfil { get; set; }  

        [Required]
        [Url]
        public string ImgPortada { get; set; }


    }
}
