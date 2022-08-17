using System.Net.Http.Json;

namespace RedSocialDeportiva.Client.Pages.LoginAndRegister.Services
{

    public class LoginAndRegisterService
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


        public async Task<(UserModels, string)> login(LoginDto form)
        {
            // TODO: Hacer que envie metodo POST y adaptarlo al respecto,.
            var result = await this.http.PostAsJsonAsync("api/User", form);

            RegisterdataDTO data = await result.Content.ReadFromJsonAsync<RegisterdataDTO>();


            UserModels UserAdapted = new UserModels();

            if (data != null && data.User != null && data.MessageError == "")
            {
                UserAdapted = adapter.CreateAdapterUser(data);
            }

            consoleJS.log("ASD", UserAdapted);

            return (UserAdapted, data.MessageError);

        }


        public async Task<string> register(RegisterDto form)
        {
            // TODO: Hacer que envie metodo POST y adaptarlo al respecto,.
            var response = await this.http.PostAsJsonAsync("api/User/register", form);

            var result = await response.Content.ReadFromJsonAsync<RegisterDataDTO>();

            consoleJS.log("ASDAS", result);

            return result.MessageError;
        }
    }
}
