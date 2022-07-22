using System.ComponentModel.DataAnnotations;

namespace RedSocialDeportiva.Client.Pages.LoginAndRegister.Dto
{
    public class RegisterDto
    {
        [RegularExpression(
            "^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)[a-zA-Z]{2,6}$",
            ErrorMessage ="El correo solo puede contener letras, numeros, puntos, guiones y guion bajo.")]
        public string? Email { get; set; }
        public string? Name { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public string? ConfirmPassword { get; set; }
    }
}
//[Required(ErrorMessage = "Campo requerido")]
//        [MinLength(2, ErrorMessage = "Error de longuitud, minimo de {1} caracteres")]
//        [MaxLength(50, ErrorMessage = "Error de longuitud, maximo de {1} caracteres")]

//// pas
//ExpReg = "(/^.{6,255}$/)",
/// Email
/// /^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$/i