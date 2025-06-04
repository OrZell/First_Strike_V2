using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace First_Strike_V2.Models
{
    public class GeminiAPI
    {
        private readonly HttpClient _HttpClient;
        private readonly string _apiKey;

        public GeminiAPI(string apiKey)
        {
            this._HttpClient = new HttpClient();
            this._apiKey = apiKey;
        }

        public async Task<string> requent(string prompt)
        {
            string url = $"https://generativelanguage.googleapis.com/v1beta/models/gemini-pro:generateContent?key={_apiKey}";

            var body = new
            {
                content = new[]
                {
                    new
                    {
                        parts = new[]
                        {
                            new {text=prompt}
                        }
                    }
                }
            };

            var json = JsonSerializer.Serialize(body);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _HttpClient.PostAsync(url, content);
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsStringAsync();
        }
    }
}
