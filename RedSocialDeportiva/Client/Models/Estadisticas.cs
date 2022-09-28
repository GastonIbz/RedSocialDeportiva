using Newtonsoft.Json;

namespace RedSocialDeportiva.Client.Models
{
    public class Estadisticas
    { 
        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("accountype")]
        public string accounType { get; set; }

        [JsonProperty("timeWindow")]
        public string timeWindow { get; set; }

        [JsonProperty("image")]
        public string image { get; set; }

        [JsonProperty("url")]
        public string url { get; set; } 
    }
}
