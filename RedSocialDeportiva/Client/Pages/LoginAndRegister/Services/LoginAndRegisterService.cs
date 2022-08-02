using RedSocialDeportiva.Shared;
using System.Net.Http.Json;

namespace RedSocialDeportiva.Client.Pages.LoginAndRegister.Services
{
    public class LoginAndRegisterService
    {

        /// Inyectamos e inicializamos en nuestra clase, el servicio http
        private readonly HttpClient http;
        private ConsoleJS consoleJS;
       
        public LoginAndRegisterService(HttpClient http, ConsoleJS consoleJS)
        {
            this.http = http;
            this.consoleJS = consoleJS;
        }


        public async Task probando()
        {
            var result = await this.http.GetFromJsonAsync<WeatherForecast[]>("WeatherForecast/PROBANDO");
            consoleJS.log <WeatherForecast[]>("Handle Login", result);
            Console.WriteLine(result);
        }
    }
}
