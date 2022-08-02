using System.Text.Json; // Permite convertir una clase en un JSON

namespace RedSocialDeportiva.Client.Utils.JsonService
{
    public class JsonService
    {
        /// TODO: NO UTILIAR, DEJAR POR EL TEMA DE SERIALZIACION.
        public JsonService() { }

        public static void ShowConsoleDataInJson<DateType>(string? message, DateType data)
        { 
            var options = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            };

            string jsonString = JsonSerializer.Serialize<DateType>(data, options);
            Console.WriteLine(message + jsonString);
        }

    }
}
