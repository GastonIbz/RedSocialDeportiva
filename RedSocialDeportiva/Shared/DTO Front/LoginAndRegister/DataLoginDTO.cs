using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedSocialDeportiva.Shared.DTO_Front.LoginAndRegister
{
    public class DataLoginDTO
    {

        #region Email

        [Required(ErrorMessage = "Campo requerido")]
        [RegularExpression(
             "^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)[a-zA-Z]{2,6}$",
             ErrorMessage = "El correo solo puede contener letras, numeros, puntos, guiones y guion bajo.")]
        public string? Email { get; set; }

        #endregion

        [Required(ErrorMessage = "Campo requerido")]
        /// TOO Poner minlenght de 6 caracteres
        [RegularExpression(@"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9]).{8,}$",
             ErrorMessage = "La contraseña debe contener al menos: 1 letra mayuscula, 1 letra minuscula y 1 numero.")]
        public string? Password { get; set; }
    }
}
