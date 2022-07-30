using System.Text.Json; // Permite convertir una clase en un JSON

namespace RedSocialDeportiva.Client.Utils.JsonService
{
    public class JsonService
    {
        
        public JsonService() { }

        public static void ShowConsoleDataInJson<T>(T data)
        { 
            var options = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            };

            string jsonString = JsonSerializer.Serialize<T>(data, options);
            Console.WriteLine("aaaa" + jsonString);
        }

    }
}
