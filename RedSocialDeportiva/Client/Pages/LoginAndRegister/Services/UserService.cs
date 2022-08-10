using RedSocialDeportiva.Client.Pages.LoginAndRegister.Adapters;
using RedSocialDeportiva.Shared;
using System.Net.Http.Json;

namespace RedSocialDeportiva.Client.Pages.LoginAndRegister.Services
{
    public class UserService
    {

        /// Inyectamos e inicializamos en nuestra clase, el servicio http
        private readonly HttpClient http;
        private ConsoleJS consoleJS;
        private LoginAndRegisterAdapter adapter;

        public UserService(HttpClient http, ConsoleJS consoleJS)
        {
            this.http = http;
            this.consoleJS = consoleJS;
        }


        public async Task login()
        {
            // TODO: Hacer que envie metodo POST y adaptarlo al respecto,.
            // TODO: Adaptar a iniciarSesion de LoginAndRegister,, axios Method , Logn.ts (service),

            var result = await this.http.GetFromJsonAsync<UserDTO>("api/User");
            UserModels UserAdapted = adapter.CreateAdapterUser(result);


            consoleJS.log("Handle probando", result);



        }
    }
}
