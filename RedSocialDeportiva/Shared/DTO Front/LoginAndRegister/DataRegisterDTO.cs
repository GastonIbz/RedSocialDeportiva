using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedSocialDeportiva.Shared.DTO_Front.LoginAndRegister
{
    public class DataRegisterDTO
    {
        #region Email 
        
            [Required(ErrorMessage = "Campo requerido")]
            [RegularExpression(
                "^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)[a-zA-Z]{2,6}$",
                ErrorMessage = "El correo solo puede contener letras, numeros, puntos, guiones y guion bajo.")]
            public string? Email { get; set; }

        #endregion

        //#region Nombre Completo

        //    [Required(ErrorMessage = "Campo requerido")]
        //    [MinLength(2, ErrorMessage = "El nombre puede contener un minimo de {1} caracteres")]
        //    [RegularExpression(
        //        "^[A-Za-zÑñÁáÉéÍíÓóÚúÜü\\s]{2,245}", ErrorMessage = "Solo puede contener letras.")]
        //    public string? NameCompleted { get; set; }
        //#endregion

        #region UserName

            [Required(ErrorMessage = "Campo requerido")]
            [MinLength(2, ErrorMessage = "El nombre de usuario puede contener un minimo de {1} caracteres")]
            [MaxLength(20, ErrorMessage = "El nombre de usuario puede contener un maximo de {1} caracteres")]
            [RegularExpression(
                "^[A-Za-zÑñÁáÉéÍíÓóÚúÜü0-9_\\.-]{2,20}$", ErrorMessage = "Puede contener letras, numeros, puntos, guiones y guion bajo.")]
            public string? UserName { get; set; }

        #endregion

        #region Password

            [Required(ErrorMessage = "Campo requerido")]
            [RegularExpression(@"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9]).{8,}$",
               ErrorMessage = "La contraseña debe contener al menos: 1 letra mayuscula, 1 letra minuscula y 1 numero.")]
            public string? Password { get; set; }

        #endregion

        #region ConfirmPassword
        
            [Required(ErrorMessage = "Campo requerido")]
            [Compare("Password", ErrorMessage = "La contraseña ingresada no coincide.")]
            public string? ConfirmPassword { get; set; }

        #endregion

    }
}