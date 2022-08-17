using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedSocialDeportiva.Shared.DTO_Back.User
{
    // TODO: Poner Etiquetas
    public class User
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string LastName { get; set; }
        public string NameCompleted { get; set; }
        public string Id { get; set; }
    }

    public class RegisterdataDTO
    {
        public User User { get; set; }
        public string Token { get; set; }
        public string MessageError { get; set; }
    }
}
