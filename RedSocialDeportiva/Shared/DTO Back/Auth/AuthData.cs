using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedSocialDeportiva.Shared.DTO_Back.Auth
{
    // TODO: Poner Etiquetas
    public class User
    { 
        public int Id { get; set; }  
        public string Username { get; set; } = string.Empty;
        public string Email { get; set; }
        public string Descripcion { get; set; }

        public string ImgPerfil { get; set; }

        public string ImgPortada { get; set; }
    }

    public class AuthData
    {
        public User User { get; set; }
        public string Token { get; set; }
        
    }
}
