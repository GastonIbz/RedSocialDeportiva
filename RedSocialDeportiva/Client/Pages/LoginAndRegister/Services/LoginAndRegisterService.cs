using System.Net.Http.Json;
using RedSocialDeportiva.Shared.DTO_Back.Auth;


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


        public async Task<(UserModels, string)> Login(DataLoginDTO form)
        {
            var resultHttp = await this.http.PostAsJsonAsync("api/Auth/login", form);

            ResponseDto<AuthData> response = await resultHttp.Content.ReadFromJsonAsync<ResponseDto<AuthData>>();

            UserModels UserAdapted = new UserModels();

            if (response != null && response.Data != null && response.MessageError == null)
            {
                UserAdapted = adapter.CreateAdapterUser(response.Data);
            }

            //consoleJS.log("ASD", UserAdapted);
            //return (UserAdapted, data.MessageError);

            return (UserAdapted, "Hubo un error mockeado");
        }


        public async Task<(string, string)> Register(DataRegisterDTO form)
        {
            var resultHttp = await this.http.PostAsJsonAsync("api/Auth/register", form);

            ResponseDto<string> response = await resultHttp.Content.ReadFromJsonAsync<ResponseDto<string>>();

            return (response.Data, response.MessageError);
        }
    }
}
