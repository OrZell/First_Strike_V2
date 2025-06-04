using System.Text;
using System.Text.Json;

namespace First_Strike_V2.Models
{
    public class Http
    {
        public class Part
        {
            public string? text { get; set; }
        }

        public class Content
        {
            public List<Part>? parts { get; set; } = new();
        }
        
        public class GeminiRequest
        {
            public List<Content>? contents { get; set; } = new();
        }

        // public class GeminiRequest
        // {
        //     public List<Content> contents { get; set; }
        // }

        public static async Task<string> SendToServer(string textMessage, string key)
        {
            GeminiRequest geminiRequest = new();
            Content contents = new();
            Part part = new();

            part.text = textMessage;
            contents.parts?.Add(part);
            geminiRequest.contents?.Add(contents);

            string Message = await Connection(geminiRequest, key);
            return Message;
        }

        static public HttpClient BaseHttp()
        {
            HttpClient Client = new();
            Client.BaseAddress = new Uri("https://generativelanguage.googleapis.com/v1beta/models/gemini-2.0-flash:generateContent/");
            return Client;
        }

        public static async Task<string> Connection(GeminiRequest geminiRequest, string key)
        {
            string json = JsonSerializer.Serialize(geminiRequest);
            HttpClient Client = BaseHttp();

            StringContent  Message = new(json, Encoding.UTF8, "application/json");
            HttpResponseMessage RequestMessage = await Client.PostAsync($"?key={key}", Message);

            if (RequestMessage.IsSuccessStatusCode)
            {

                return await RequestMessage.Content.ReadAsStringAsync();
            }
            else
            {
                return $"Error: {RequestMessage.StatusCode}, {await RequestMessage.Content.ReadAsStringAsync()}";

            }
        }
        
    }
    
}