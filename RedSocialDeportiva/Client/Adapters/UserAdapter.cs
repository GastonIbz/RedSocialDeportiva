using RedSocialDeportiva.Shared.DTO_Back.Auth;

namespace RedSocialDeportiva.Client.Adapters
{
    public class UserAdapter
    {

        public UserModels CreateAdapterUser(AuthData dataUser)
        {

            UserModels formattedUser = new UserModels
            {
                Email = dataUser.User.Email,
                Id = dataUser.User.Id,
                ImgPerfil = dataUser.User.ImgPerfil,
                ImgPortada= dataUser.User.ImgPortada,
                UserName = dataUser.User.Username,
                Token = dataUser.Token,
            };

            return formattedUser;
        }
    }
}
