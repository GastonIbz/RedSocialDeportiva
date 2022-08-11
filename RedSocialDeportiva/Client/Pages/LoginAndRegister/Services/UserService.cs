using RedSocialDeportiva.Shared;
using System.Net.Http.Json;

namespace RedSocialDeportiva.Client.Pages.LoginAndRegister.Services
{
    public class UserService
    {

        /// Inyectamos e inicializamos en nuestra clase, el servicio http
        private readonly HttpClient http;
        private readonly ConsoleJS consoleJS;
        private LoginAndRegisterAdapter adapter;

        public UserService(HttpClient http, ConsoleJS consoleJS, LoginAndRegisterAdapter adapter )
        {
            this.http = http;
            this.consoleJS = consoleJS;
            this.adapter = adapter;
        }


        public async Task<(UserModels, string)> login()
        {
            // TODO: Hacer que envie metodo POST y adaptarlo al respecto,.
   
            UserModels UserAdapted = new UserModels();

            LoginDataDTO result = await this.http.GetFromJsonAsync<LoginDataDTO>("api/User");

            if (result != null && result.User != null && result.MessageError == "")
            {
                UserAdapted = adapter.CreateAdapterUser(result);
            }

            return (UserAdapted, result.MessageError);
        }
    }
}
