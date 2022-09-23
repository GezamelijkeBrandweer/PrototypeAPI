using System.Text.Json.Nodes;

namespace OpenMeteoAPILib
{
    public static class OpenMeteo
    {

        private static readonly HttpClient OpenMeteoClient = new()
        {
            BaseAddress = new Uri("https://api.open-meteo.com/v1/"),
        };
        
        public static async Task<JsonNode> GetWeerInfo(double? latitude, double? longitude)
        {
            
            using var response = await OpenMeteoClient.GetAsync($"forecast?latitude={latitude}&longitude={longitude}&hourly=temperature_2m,relativehumidity_2m,rain,windspeed_10m,winddirection_10m,windgusts_10m");
            
            response.EnsureSuccessStatusCode();
            var jsonResponse = await response.Content.ReadAsStringAsync();
            
            return JsonNode.Parse(jsonResponse);
        }
    }
}