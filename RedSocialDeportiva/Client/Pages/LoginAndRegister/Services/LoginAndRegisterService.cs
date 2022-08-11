using RedSocialDeportiva.Shared;
using System.Net.Http.Json;

namespace RedSocialDeportiva.Client.Pages.LoginAndRegister.Services
{
    public class LoginAndRegisterService : ILoginAndRegisterService
    {

        /// Inyectamos e inicializamos en nuestra clase, el servicio http
        private readonly HttpClient http;
        private readonly ConsoleJS consoleJS;
        private UserAdapter adapter;

        public LoginAndRegisterService(HttpClient http, ConsoleJS consoleJS, UserAdapter adapter)
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

            consoleJS.log("ASD", UserAdapted);

            return (UserAdapted, result.MessageError);
        }
    }
}
