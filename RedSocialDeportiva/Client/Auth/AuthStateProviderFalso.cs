﻿using Microsoft.AspNetCore.Components.Authorization;

namespace RedSocialDeportiva.Client.Auth
{
    public class AuthStateProviderFalso : AuthenticationStateProvider
    {
        public override Task<AuthenticationState> GetAuthenticationStateAsync()//Este metodo determina si el usuario
                                                 //Esta autenticado o no 
        {
            throw new NotImplementedException();
        }
    }
}
