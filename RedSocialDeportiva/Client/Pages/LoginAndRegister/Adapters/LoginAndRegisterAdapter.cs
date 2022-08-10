namespace RedSocialDeportiva.Client.Pages.LoginAndRegister.Adapters
{
    public class LoginAndRegisterAdapter
    {

        public UserModels CreateAdapterUser(UserDTO dataUser)
        {

            UserModels formattedUser = new UserModels
            {
                Email = dataUser.Email,
                Id = dataUser.Id,
                LastName = dataUser.LastName,
                NameCompleted = dataUser.NameCompleted,
                UserName = dataUser.UserName,
                Token = dataUser.Token,
            };

            return formattedUser;
        }
    }
}
