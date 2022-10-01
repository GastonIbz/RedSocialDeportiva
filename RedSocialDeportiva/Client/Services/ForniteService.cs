using Newtonsoft.Json;

namespace RedSocialDeportiva.Client.Services
{
    public class ForniteService : IForniteService
    { 
        private readonly HttpClient _httpClient;
        public ForniteService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

    
        public async Task<Estadisticas> GetEstadisticasBR(string name)
        {

          _httpClient.DefaultRequestHeaders.Add("Authorization", "590a9653-554f-463c-bb9f-34da6dea22c2");
            return JsonConvert.DeserializeObject<Estadisticas>(await _httpClient.GetStringAsync($"?name={name}"));
            
            
        }
    }
}
