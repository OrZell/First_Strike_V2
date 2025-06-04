using System;
﻿using System.Text;
using System.Text.Json;

namespace First_Strike_V2.Models
{
    public class GeminiAPI
    {
        private readonly HttpClient _HttpClient;
        private readonly string _apiKey;

        public GeminiAPI(string apiKey)
        {
            this._HttpClient = new HttpClient();
            this._HttpClient.BaseAddress = new Uri($"https://generativelanguage.googleapis.com/v1beta/models/gemini-2.0-flash:generateContent?key={apiKey}");
            this._apiKey = apiKey;
        }

        public async Task<string> requent(string prompt)
        {
            var body = new
            {
                contents = new[]
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
            var contant = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _HttpClient.PostAsync(this._HttpClient.BaseAddress, contant);

            return await response.Content.ReadAsStringAsync();
        }
    }
}
