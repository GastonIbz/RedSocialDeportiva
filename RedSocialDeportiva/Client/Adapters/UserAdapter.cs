﻿namespace RedSocialDeportiva.Client.Adapters
{
    public class UserAdapter
    {

        public UserModels CreateAdapterUser(LoginDataDTO dataUser)
        {

            UserModels formattedUser = new UserModels
            {
                Email = dataUser.User.Email,
                Id = dataUser.User.Id,
                LastName = dataUser.User.LastName,
                NameCompleted = dataUser.User.NameCompleted,
                UserName = dataUser.User.UserName,
                Token = dataUser.Token,
            };

            return formattedUser;
        }
    }
}
